using ApartmentCare.Clase.PentruAsociatie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase
{
    internal class Administrator
    {
        private string cheieLicenta;
        private string nume;
        private string nrTelefon;
        private string email;
        private string parola;
        private List<Asociatie> asociatii;

        public Administrator() { }

        public Administrator(string cheieLicenta, string nume, string nrTelefon, string email, string parola, List<Asociatie> asociatii)
        {
            this.cheieLicenta = cheieLicenta;
            this.nume = nume;
            this.nrTelefon = nrTelefon;
            this.email = email;
            this.parola = parola;
            this.asociatii = asociatii;
        }

        public string CheieLicenta { get => cheieLicenta; set => cheieLicenta = value; }
        public string Nume { get => nume; set => nume = value; }
        public string NrTelefon { get => nrTelefon; set => nrTelefon = value; }
        public string Email { get => email; set => email = value; }
        public string Parola { get => parola; set => parola = value; }
        internal List<Asociatie> Asociatii { get => asociatii; set => asociatii = value; }


    }
}
