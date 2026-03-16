using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg_Console
{
    internal class Employee(int id, string navn, int station)
    {
        public int id { get; } = id; //primary
        public string navn { get; } = navn;
        public int Station { get; set; } = station; //nullable int?

    }
}
