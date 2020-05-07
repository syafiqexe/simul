using System;

namespace p
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("\tjenis printer");
            Console.WriteLine("1.canon");
            Console.WriteLine("2.epson");
            Console.WriteLine("3.laser jet");
            int pilihprinter = Convert.ToInt32(Console.ReadLine());

            if (pilihprinter == 1)
                printer = new Canon();
            else if (pilihprinter == 2)
                printer = new Epson();
            else
                printer = new LaserJet();

            printer.show();

            Console.ReadKey();
        }
    }
}
