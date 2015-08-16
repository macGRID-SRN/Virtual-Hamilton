using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charettes
{
    public enum GridName
    {
        MainEmerson,
        MohawkGarth,
        BartonKennelworth
    };

    public class Grid
    {
        public SerialPort Port { get; set; }

        public Grid(SerialPort port)
        {
            Port = port;
        }
    }
}
