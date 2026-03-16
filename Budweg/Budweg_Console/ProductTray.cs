using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg_Console
{
    internal class ProductTray(int id, Product product, int antal = 0)
    {
        private int antal = antal;
        public int Id { get; } = id;
        public int Antal { get { return antal; } set { antal = value >= 0 ? value : 0; } }

        public Product Product { get; set; } = product;
    }
}
