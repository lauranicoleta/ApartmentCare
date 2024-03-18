using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase
{
    internal class Contor
    {
        private string serie;
        private string tip;
        private string titlu;
        private double indexInitial;
        private double indexFinal;

        public Contor()
        {
        }

        public Contor(string serie, string tip, string titlu, double indexInitial, double indexFinal)
        {
            this.serie = serie;
            this.tip = tip;
            this.titlu = titlu;
            this.indexInitial = indexInitial;
            this.indexFinal = indexFinal;
        }


        public string Serie { get => serie; set => serie = value; }
        public string Tip { get => tip; set => tip = value; }
        public string Titlu { get => titlu; set => titlu = value; }
        public double IndexInitial { get => indexInitial; set => indexInitial = value; }
        public double IndexFinal { get => indexFinal; set => indexFinal = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
