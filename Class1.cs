using System;
using System.Collections.Generic;
using System.Text;

namespace p
{
    class PrinterWindows
    {
        public virtual void show()
        {
            Console.WriteLine("");
        }
    }



    class Canon : PrinterWindows
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("canon display dimension is 9.5 x 12");
            Console.WriteLine("canon printer printing...");
        }
    }

    class Epson : PrinterWindows
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("Epson display dimension is 10 x 11");
            Console.WriteLine("Epson printer printing...");
        }
    }

    class LaserJet : PrinterWindows
    {
        public override void show()
        {
            base.show();
            Console.WriteLine("Laser Jet display dimension is 12 x 12");
            Console.WriteLine("Laser Jet printer printing...");
        }
    }
}
    