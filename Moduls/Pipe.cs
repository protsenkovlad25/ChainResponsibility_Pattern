using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conveyor_ChainResponsibility.Production;

namespace Conveyor_ChainResponsibility.Moduls
{
    class Pipe : Conveyor
    {
        public override void Processing(Raw raw)
        {
            if (raw.Pipe == true)
                Console.WriteLine("Warehouse: Pipe");
            else if (Successor != null)
                Successor.Processing(raw);
        }
    }
}
