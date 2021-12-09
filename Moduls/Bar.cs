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
        public int target = 3;

        public override void Processing()
        {
            if (target == Target)
                Console.WriteLine("Warehouse: Bar");
            else if (Successor != null)
                Successor.Processing();
        }
    }
}
