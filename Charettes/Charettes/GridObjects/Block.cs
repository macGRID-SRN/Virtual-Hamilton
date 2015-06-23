using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charettes.GridObjects
{
    public class Block : GridObject
    {
        public Block(int x, int y, string uniqueId, string name)
            : base(x, y, uniqueId, name)
        {

        }

        public override string ToString()
        {
            return string.Format(TextFileLine,name,uniqueId,x,y,25,2,2,2,0,0,0);
        }
    }

}
