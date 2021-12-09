using System;
using Conveyor_ChainResponsibility.Production;
using Conveyor_ChainResponsibility.Moduls;

namespace Conveyor_ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products:\n" +
                "(1) Angle\n" +
                "(2) Armature\n" +
                "(3) Bar\n" +
                "(4) Pipe\n" +
                "(5) Square\n");

            Console.Write("Choose a product: ");
            int target = Convert.ToInt32(Console.ReadLine());

            //Raw raw = new Raw(target);
            
            Conveyor armature = new Armature();
            Conveyor bar = new Bar();
            Conveyor pipe = new Pipe();
            Conveyor square = new Square();
            Conveyor angle = new Angle();
            armature.Successor = bar;
            bar.Successor = pipe;
            pipe.Successor = square;
            square.Successor = angle;

            Conveyor.Target = target;
            armature.Processing();
        }
    }
}
