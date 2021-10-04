using System;
using Devices.Services;

namespace Devices.Entities
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string doc)
        {
            Console.WriteLine("Printer print " + doc);
        }
    }
}
