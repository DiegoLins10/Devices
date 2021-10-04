using System;
using Devices.Services;

namespace Devices.Entities
{
    class Scanner : Device, IScanner
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
