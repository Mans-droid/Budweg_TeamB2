using System;
using System.Collections.Generic;
using System.Text;

namespace Budweg_Console
{
    internal class Workorder(int id, int nummer, int tilgang = 0, int afgangFrem = 0, int afgangTilbage = 0, int spild = 0)
    {
        private int tilgang = tilgang;
        private int afgangFrem = afgangFrem;
        private int afgangTilbage = afgangTilbage;
        private int spild = spild;
        public int Id { get; } = id; //primary

        public int nummmer { get; } = nummer; //Samme OrderLink nummer bruges til at samle flere instancer af følgeseddel

        public int Tilgang { get { return tilgang; } set { tilgang = value >= 0 ? value : 0; } }

        public int AfgangFrem { get { return afgangFrem; } set { afgangFrem = value >= 0 ? value : 0; } }

        public int AfgangTilbage { get { return afgangTilbage; } set { afgangTilbage = value >= 0 ? value : 0; } }

        public int Spild { get { return spild; } set { spild = value >= 0 ? value : 0; } }

        public int Employee { get; set; }
    }
}
