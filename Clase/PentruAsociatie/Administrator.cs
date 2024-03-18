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
        private string nume;
        private string nrTelefon;
        private string email;
        private string parola;
       
        public Administrator() { }

        
        public Administrator(string nume, string nrTelefon, string parola) { 
            this.nume = nume;
            this.nrTelefon = nrTelefon;
            this.email = email;
            this.parola = parola;
        }

        public string Nume { get => nume; set => nume = value; }
        public string NrTelefon { get => nrTelefon; set => nrTelefon = value; }
        public string Email { get => email; set => email = value; }
        public string Parola { get => parola; set => parola = value; }
    }
}
