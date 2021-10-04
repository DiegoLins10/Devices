using Devices.Entities;
using Devices.Services;
using System;

namespace Devices
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = "1020" };
            p.ProcessDoc("diego.pdf");
            p.Print("My letter");

            Scanner sc = new Scanner() { SerialNumber = "1444"};
            sc.ProcessDoc("My email");
            Console.WriteLine(sc.Scan());

            ComboDevice c = new ComboDevice() {SerialNumber =  "854458" };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}
