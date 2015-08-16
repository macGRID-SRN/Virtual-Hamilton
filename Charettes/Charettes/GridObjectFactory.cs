using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charettes.GridObjects;

namespace Charettes
{
    public static class GridObjectFactory
    {

        public static GridObject GetGridObject(int x, int y)
        {
            var locationInGrid = MapScreenCoords2OpenSim(x, y);
            return new Block(locationInGrid.X, locationInGrid.Y, GenerateRandomUniqueId(), Config.CurrentObjectState);
        }

        public static GridObject GetGridObject(int x, int y, string uniqueId)
        {
            var locationInGrid = MapScreenCoords2OpenSim(x, y);

            return new Block(locationInGrid.X, locationInGrid.Y, uniqueId, Config.CurrentObjectState);
        }

        private static Point MapScreenCoords2OpenSim(int x, int y)
        {
            return new Point(Round2Int(x * (255 / 1920.0)), Round2Int(y * (255 / 1080.0)));
        }

        //from http://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings-in-c
        private static string GenerateRandomUniqueId()
        {
            while (true)
            {
                var chars = "0123456789";
                var random = new Random();
                var result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
                if (!ObjectTracker.UniqueItemExists(result))
                    return result;
            }
        }

        private static int Round2Int(double number)
        {
            return Convert.ToInt32(Math.Round(number));
        }

    }
}
