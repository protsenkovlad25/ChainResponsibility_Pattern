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
        public override void Processing(Raw raw)
        {
            if (raw.Armature == true)
                Console.WriteLine("Warehouse: Armature");
            else if (Successor != null)
                Successor.Processing(raw);
        }
    }
}
