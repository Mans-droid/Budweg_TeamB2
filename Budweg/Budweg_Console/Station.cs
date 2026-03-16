using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg_Console
{
    internal class Station(int id, string navn, DateTime? tidInd = null)
    {
        private DateTime? tidInd = tidInd;

        private DateTime? tidUd = null;
        public int Id { get; } = id; //primary
        public string Navn { get; } = navn;
        public DateTime? TidInd { get { return tidInd; } }
        public DateTime? TidUd { 
            get { return tidUd; } 
            set { tidUd = value > tidInd ? value : tidInd; } 
        }
    }
}
