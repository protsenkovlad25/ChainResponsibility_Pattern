using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conveyor_ChainResponsibility.Production;

namespace Conveyor_ChainResponsibility.Moduls
{
    class Bar : Conveyor
    {
        public override void Processing(Raw raw)
        {
            if (raw.Bar == true)
                Console.WriteLine("Warehouse: Bar");
            else if (Successor != null)
                Successor.Processing(raw);
        }
    }
}
