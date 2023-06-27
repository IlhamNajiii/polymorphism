using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsm
{
    abstract class printerWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }
        public abstract void Print();
    }
    class Epson : printerWindows
    {
        public override void Print()
        {
            Console.WriteLine("Epson Printer printing...");
        }
        public override void Show()
        {
            Console.WriteLine("Epson Windows display dimension: 10 * 11");
        }
    }

    class Canon : printerWindows
    {
        public override void Print()
        {
            Console.WriteLine("Canon Printer printing...");
        }
        public override void Show()
        {
            Console.WriteLine("Epson Windows display dimension: 9.5 * 12");
        }
    }
    class LaserJet : printerWindows
    {
        public override void Print()
        {
            Console.WriteLine("LaserJet Printer printing...");
        }
        public override void Show()
        {
            Console.WriteLine("Epson Windows display dimension: 12 * 12");
        }
    }
}