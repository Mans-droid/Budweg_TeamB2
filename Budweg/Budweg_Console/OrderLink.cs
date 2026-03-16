using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg_Console
{
    internal class OrderLink(int id)
    {
        public int Id { get; } = id; //primary

        public int[]? Følgeseddel { get; set; } //OrderLink holder ikke styr på følgsedle
    }
}
