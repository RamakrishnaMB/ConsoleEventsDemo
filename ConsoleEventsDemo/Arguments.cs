using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEventsDemo
{
    public class Arguments : EventArgs
    {
        public string Argument1 { get; set; }
        public string Argument2 { get; set; }
    }
}
