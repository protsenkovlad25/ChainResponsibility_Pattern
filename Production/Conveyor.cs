using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveyor_ChainResponsibility.Production
{
    abstract class Conveyor
    {
        public static int Target;

        public Conveyor Successor { get; set; }
        public abstract void Processing();
    }
}
