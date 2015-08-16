using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charettes.GridObjects
{
    public enum GridObjectType
    {
        Block
    }
    public abstract class GridObject
    {
        //name,uniqueID,position<x,y,z>,size<x,y,z>,angle<x,y,z>
        public static string TextFileLine = "{0},{1},<{2},{3},{4}>,<{5},{6},{7}>,<{8},{9},{10}>";
        public int x { get; set; }
        public int y { get; set; }
        public string uniqueId { get; set; }
        public string name { get; set; }

        protected GridObject(int x, int y, string uniqueId, string name)
        {
            this.x = x;
            this.y = y;
            this.uniqueId = uniqueId;
            this.name = name;
        }

    }
}
