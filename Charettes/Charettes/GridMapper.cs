using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Drawing;
using Charettes.GridObjects;


namespace Charettes
{
    class GridMapper
    {
        private Capture _capture;
        private StringBuilder _sb ;
        private string _path;
        private List<GridObject> _gridObjects;
        public GridMapper(Grid macGrid)
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\testcv.txt";
            _gridObjects = new List<GridObject>();
            ShowScreen();
        }

        private void ShowScreen()
        {
            var viewer = new ImageViewer(); //create an image viewer
            
            _capture = new Capture(); //create a camera captue
            var starttime = DateTime.UtcNow;
            Application.Idle += new EventHandler(delegate(object sender, EventArgs e)
            {
                Image<Gray, Byte> cannyImage = _capture.QueryGrayFrame().ThresholdBinary(new Gray(250), new Gray(255)).Canny(new Gray(255).Intensity, new Gray(255).Intensity).Resize(1900, 1080, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR).Copy();
                var count = 0;
                _gridObjects.Clear();
                for (Contour<Point> contours = cannyImage.FindContours(
                                Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                                Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_EXTERNAL); contours != null; contours = contours.HNext)
                {
                    count++;
                    var x = (float)contours.BoundingRectangle.X;
                    var y = (float)contours.BoundingRectangle.Y;
                    var gridObject = GridObjectFactory.GetGridObject(Convert.ToInt32(x), Convert.ToInt32(y));
                    if(ObjectTracker.IsObjectPastThresholdDistance(gridObject))
                        _gridObjects.Add(gridObject);
                }
                if(starttime - DateTime.UtcNow > TimeSpan.FromMilliseconds(5000))
                    ObjectTracker.UpdateList(_gridObjects);
                var numDivisions = 255;
                var height = cannyImage.Size.Height;
                var width = cannyImage.Size.Width;
                var startx = width / numDivisions;
                var starty = height / numDivisions;
                var color = new Gray(200);
                for (var i = 0; i <= numDivisions; i++)
                {
                    //Draw Horizontal Line
                    cannyImage.Draw(new LineSegment2D(new Point(0, starty * i ), new Point(width, starty * i)), color, 1);
                    //Draw Vertical Line
                    cannyImage.Draw(new LineSegment2D(new Point(startx * i, 0), new Point(startx * i, height)), color, 1);
                }
                var f = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_COMPLEX, 1.0, 1.0);
                cannyImage.Draw(count.ToString(), ref f, new Point(10, 80), color); 
                viewer.Image = cannyImage;
                //viewer.Image = _capture.QueryFrame().Resize(1900, 1080, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR).Copy(); //draw the image obtained from camera
            });
            viewer.ShowDialog();
        }

    }
}
