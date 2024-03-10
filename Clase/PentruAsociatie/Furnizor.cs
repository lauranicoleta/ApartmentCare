using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruAsociatie
{
    internal class Furnizor
    {
        private string cui;
        private string denumireFurnizor;
        private string descriereImplicita;

        public Furnizor() { }

        public Furnizor(string cUI, string denumireFurnizor, string descriereImplicita)
        {
            this.cui = cUI;
            this.denumireFurnizor = denumireFurnizor;
            this.descriereImplicita = descriereImplicita;
        }

        public string Cui { get => cui; set => cui = value; }
        public string DenumireFurnizor { get => denumireFurnizor; set => denumireFurnizor = value; }
        public string DescriereImplicita { get => descriereImplicita; set => descriereImplicita = value; }
    }
}
