using System;
using System.Collections.Generic;
using System.Text;

namespace Devices.Entities
{
    class Scanner : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scan result";
        }


    }
}
