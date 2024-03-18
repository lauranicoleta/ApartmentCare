using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruAsociatie
{
    internal class Fond
    {
        private string tipFond;
        private double soldFond;

        public Fond() { }
        public Fond(string tipFond, double soldFond)
        {
            this.tipFond = tipFond;
            this.soldFond = soldFond;
        }

        public string TipFond { get => tipFond; set => tipFond = value; }
        public double SoldFond { get => soldFond; set => soldFond = value; }
    }
}
