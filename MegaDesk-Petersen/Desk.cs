using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Petersen
{
    public enum DesktopMaterial
    {
        Oak = 200,
        Rosewood = 300,
        Laminate = 100,
        Veneer = 125,
        Pine = 50
    }

    class Desk
    {
        //members
        private double width;
        private double depth;
        private uint drawersNum;
        

        //methods
        public double Width { get; set; }
        public double Depth { get; set; }
        public uint DrawersNum { get; set; }

    }
}
