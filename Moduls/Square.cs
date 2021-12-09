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
        public int target = 5;

        public override void Processing()
        {
            if (target == Target)
                Console.WriteLine("Warehouse: Square");
            else if (Successor != null)
                Successor.Processing();
        }
    }
}
