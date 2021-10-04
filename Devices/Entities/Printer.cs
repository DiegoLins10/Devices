using System;
using System.Collections.Generic;
using System.Text;

namespace Devices.Entities
{
    class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public string Print(string doc)
        {
            return "Print " + doc;
        }
    }
}
