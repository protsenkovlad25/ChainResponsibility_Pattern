using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveyor_ChainResponsibility.Production
{
    class Raw
    {
        public bool Armature { get; set; }
        public bool Bar { get; set; }
        public bool Pipe { get; set; }
        public bool Square { get; set; }
        public bool Angle { get; set; }

        public Raw(int target)
        {
            switch(target)
            {
                case 1:
                    Angle = true;
                    Armature = false;
                    Bar = false;
                    Pipe = false;
                    Square = false;
                    break;
                case 2:
                    Angle = false;
                    Armature = true;
                    Bar = false;
                    Pipe = false;
                    Square = false;
                    break;
                case 3:
                    Angle = false;
                    Armature = false;
                    Bar = true;
                    Pipe = false;
                    Square = false;
                    break;
                case 4:
                    Angle = false;
                    Armature = false;
                    Bar = false;
                    Pipe = true;
                    Square = false;
                    break;
                case 5:
                    Angle = false;
                    Armature = false;
                    Bar = false;
                    Pipe = false;
                    Square = true;
                    break;
                default:
                    Console.WriteLine("Not identified");
                    break;
            }
        }
    }
}
