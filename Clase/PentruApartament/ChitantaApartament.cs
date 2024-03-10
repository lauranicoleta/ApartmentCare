using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruApartament
{
    internal class ChitantaApartament
    {
        private static int _idChitantaApartament = 0;
        private int Id;
        private string tip;
        private string descriere;
        private double suma;
        private DateTime dataChitanta;
        private Boolean incasatInCont;

        public ChitantaApartament()
        {
            this.Id = Interlocked.Increment(ref _idChitantaApartament);
            this.dataChitanta = DateTime.Today;
            this.incasatInCont = false;
        }

        public ChitantaApartament(string tip, string descriere, double suma, DateTime dataChitanta, bool incasatInCont)
        {
            this.tip = tip;
            this.descriere = descriere;
            this.suma = suma;
            this.dataChitanta = dataChitanta;
            this.incasatInCont = incasatInCont;
        }

        public string Tip { get => tip; set => tip = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public double Suma { get => suma; set => suma = value; }
        public DateTime DataChitanta { get => dataChitanta; set => dataChitanta = value; }
        public bool IncasatInCont { get => incasatInCont; set => incasatInCont = value; }
    }
}
