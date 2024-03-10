using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruAsociatie
{
    internal class ContBancar
    {
        private string titlu;
        private string iban;
        private double sold;

        public ContBancar() { }

        public ContBancar(string titlu, string iban, double sold)
        {
            this.titlu = titlu;
            this.iban = iban;
            this.sold = sold;
        }

        public string Titlu { get => titlu; set => titlu = value; }
        public string Iban { get => iban; set => iban = value; }
        public double Sold { get => sold; set => sold = value; }

        public override string ToString()
        {
            return $"Titlu: {Titlu}, IBAN: {Iban}, Sold: {Sold}";
        }
    }
}
