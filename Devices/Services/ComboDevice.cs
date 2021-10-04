﻿using System;
using Devices.Entities;
namespace Devices.Services
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice Scan Result";
        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }
    }
}
