using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Charettes.GridObjects;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Charettes
{
    public static class ObjectTracker
    {
        private static readonly int MAX_OBJECTS_TRACKED = 8;
        public static bool TrackingImageListBeingUpdated = false;
        public static List<TrackedObject> TrackingImages = new List<TrackedObject>(); 
 
        private static List<GridObject> _uniqueItemList = new List<GridObject>();

        public static void AddOrUpdate(GridObject gridObject)
        {
            var ob = _uniqueItemList.FirstOrDefault(l => l.uniqueId == gridObject.uniqueId);
            if (ob != null)
            {
                ob.x = gridObject.x;
                ob.y = gridObject.y;
            }
            else
            {
                _uniqueItemList.Add(gridObject);
            }
            UpdateTextFile();
        }

        public static void UpdateTrackingList(TrackedObject obj)
        {
            TrackingImageListBeingUpdated = true;
            if (TrackingImages.Count >= MAX_OBJECTS_TRACKED)
            {
                TrackingImages.RemoveAt(0);
                TrackingImages.Add(obj);
            }
            else
            {
                TrackingImages.Add(obj);
            }
            TrackingImageListBeingUpdated = false;
        }

        public static void UpdateList(List<GridObject> gridObjectList )
        {
            _uniqueItemList = gridObjectList;
            var coords = string.Empty;
            gridObjectList.ForEach(l =>
            {
                coords = coords + l.x + "," + l.y + "," + l.name + ",";
            });
            coords = coords.TrimEnd(',');
            SendData.Send(coords);
           // UpdateTextFile();
        }

        public static bool UniqueItemExists(string uniqueId)
        {
            return _uniqueItemList.Exists(l => l.uniqueId == uniqueId);
        }

        public static bool IsObjectPastThresholdDistance(GridObject gridObject)
        {
            return _uniqueItemList.All(item => !(Math.Sqrt(Math.Pow(item.x - gridObject.x, 2) + Math.Pow(item.y - gridObject.y, 2)) < 3));
        }

        private static void UpdateTextFile()
        {
            try
            {
                const string path = @"C:\Users\Dom\Google Drive\Work\RA Job\Projects\Virtual Hamilton\opensimlocations.txt";
                File.Create(path).Close();
                using (var sw = new StreamWriter(path))
                {
                    foreach (var item in _uniqueItemList)
                        sw.WriteLine(item.ToString());
                }
            }
            catch (IOException)
            {

            }
        }

        public class TrackedObject
        {
            public Image<Gray, byte> Image { get; set; }
            public string Path { get; set; }
        }

    }
}
