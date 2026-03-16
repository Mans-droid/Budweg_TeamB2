using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg_Console
{
    enum Type
    {
        bremsekalibre,
        EBPkalibre,
        reserve
    }
    internal class Product(Type type, string mærke = "ukendt")
    {
        public Type Type { get; set; } = type;
        public string Mærke { get; set; } = mærke;
    }
}
