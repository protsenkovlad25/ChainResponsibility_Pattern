using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conveyor_ChainResponsibility.Production;

namespace Conveyor_ChainResponsibility.Moduls
{
    class Square : Conveyor
    {
        public override void Processing(Raw raw)
        {
            if (raw.Square == true)
                Console.WriteLine("Warehouse: Square");
            else if (Successor != null)
                Successor.Processing(raw);
        }
    }
}
