using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conveyor_ChainResponsibility.Production;

namespace Conveyor_ChainResponsibility.Moduls
{
    class Armature : Conveyor
    {
        public int target = 2;

        public override void Processing()
        {
            if (target == Target)
                Console.WriteLine("Warehouse: Armature");
            else if (Successor != null)
            {
                Console.WriteLine("Переход от Арматуры к Angle");
                Successor.Processing();
            }
        }
    }
}
