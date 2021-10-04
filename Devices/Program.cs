using Devices.Entities;
using System;

namespace Devices
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = "1020" };
            p.ProcessDoc("diego.pdf");
            Console.WriteLine(p.Print("My letter"));

            Scanner sc = new Scanner();
            sc.ProcessDoc("My email");
            Console.WriteLine(sc.Scan());

        }
    }
}
