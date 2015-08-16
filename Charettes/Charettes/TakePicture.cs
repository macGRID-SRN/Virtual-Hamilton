using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace Charettes
{
    public partial class TakePicture : Form
    {
        private const string Dir = "Images/";
        private readonly Capture _capture;        //takes images from camera as image frames
        private bool _captureInProgress;
        private bool _inLiveViewMode;
        private bool _saveToFile;
        private int _count;

        public TakePicture()
        {
            this._capture = new Capture();
            InitializeComponent();
            _inLiveViewMode = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TakePicture_Load(object sender, EventArgs e)
        {
            SetPictureMode();
        }

        private void SetPictureMode()
        {
            lblMode.Text = "Picture Taking Mode";
            Application.Idle += SetPictureFeed;
        }


        private void SetLiveViewMode()
        {
            lblMode.Text = "Object Mapping Mode";
            //Application.Idle += SetLiveFeed;
        }

        private void SaveFrame()
        {
            btnSwitchMode.Enabled = false;
            btnCapture.Enabled = false;
            _saveToFile = true;
            Image<Gray, byte> imageFrame = _capture.QueryGrayFrame();
            imageBoxLiveFeed.Image = imageFrame;
            imageFrame.Save(GetAbsolutePath());
            ObjectTracker.UpdateTrackingList(new ObjectTracker.TrackedObject()
            {
                Image = imageFrame,
                Path = GetAbsolutePath()
            });
            UpdateImageListDisplay(imageFrame);
            _count++;
            btnCapture.Text = "Capture";
            _captureInProgress = false;
            _saveToFile = false;
            btnCapture.Enabled = true;
            btnSwitchMode.Enabled = true;
        }

        private void ReleaseCamera()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private static string GetAbsolutePath()
        {
            var filename = string.Format("{0}.jpg", DateTime.Now.Ticks);
            return Path.Combine(Dir, filename);
        }

        private void ClearImageDirectory(string cameraPath)
        {
            if (Directory.Exists(cameraPath))
            {
                var root = new DirectoryInfo(cameraPath);
                var files = root.GetFiles();
                foreach (var file in files)
                    file.Delete();
            }
            else
                Directory.CreateDirectory(cameraPath);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!_captureInProgress)
            {
                btnCapture.Text = "...";
                _captureInProgress = true;
                SaveFrame();
            }
            else
            {
                MessageBox.Show("Capture is In progress!");
            }
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            if (_inLiveViewMode)
            {
                btnCapture.Enabled = true;
                //Application.Idle -= SetLiveFeed;
                _inLiveViewMode = false;
                SetPictureMode();

            }
            else
            {
                btnCapture.Enabled = false;
                Application.Idle -= SetPictureFeed;
                _inLiveViewMode = true;
                SetLiveViewMode();
            }
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateImageListDisplay(Image<Gray, byte> image)
        {
            _count = _count % 8;
            switch (_count)
            {
                case 0:
                    imageBox1.Image = image.Resize(245,181, INTER.CV_INTER_LINEAR);
                    break;
                case 1:
                    imageBox2.Image = image.Resize(245,181, INTER.CV_INTER_LINEAR);
                    break;
                case 2:
                    imageBox3.Image = image.Resize(245, 181, INTER.CV_INTER_LINEAR);
                    break;
                case 3:
                    imageBox4.Image = image.Resize(245, 181, INTER.CV_INTER_LINEAR);
                    break;
                case 4:
                    imageBox5.Image = image.Resize(245, 181, INTER.CV_INTER_LINEAR);
                    break;
                case 5:
                    imageBox6.Image = image.Resize(245, 181, INTER.CV_INTER_LINEAR);
                    break;
                case 6:
                    imageBox7.Image = image.Resize(245, 181, INTER.CV_INTER_LINEAR);
                    break;
                case 7:
                    imageBox8.Image = image.Resize(245, 181, INTER.CV_INTER_LINEAR);
                    break;
            }
        }

        private void SetPictureFeed(object sender, EventArgs e)
        {
            var image =
                     _capture.QueryGrayFrame().Resize(960, 540, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            imageBoxLiveFeed.Image = image;
        }

        //private void SetLiveFeed(object sender, EventArgs e)
        //{
        //   // foreach (var im in ObjectTracker.TrackingImages)
        //    //{
        //        var image =
        //            _capture.QueryGrayFrame().Resize(1920, 1080, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
        //        imageBoxLiveFeed.Image = GridMapper.Draw(ObjectTracker.TrackingImages[0].Image, image).Resize(960, 540, INTER.CV_INTER_LINEAR);
        //    //}
        //}

    }
}
