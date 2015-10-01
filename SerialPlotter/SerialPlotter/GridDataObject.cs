using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPlotter
{
    public class GridDataObject
    {
        public static List<GridDataObject> physicalObjects = new List<GridDataObject>
    {
        new GridDataObject
        {
            Id = 1,
            Name = "bike"
        },
        new GridDataObject
        {
            Id = 2,
            Name = "bench"
        },
        new GridDataObject
        {
            Id = 1,
            Name = "zebra"
        },
        new GridDataObject
        {
            Id = 1,
            Name = "phone"
        },
        new GridDataObject
        {
            Id = 1,
            Name = "garbage"
        },
    };
        public string Name;
        public int Id;
        public int x;
        public int y;

        public string sendString
        {
            get { return string.Format("{0},{1},{2}", Name, x, y); }
        }
    }
}
