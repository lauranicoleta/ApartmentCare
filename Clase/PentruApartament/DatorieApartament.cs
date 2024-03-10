using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentCare.Clase
{
    internal class DatorieApartament
    {
        private static int _idDatorieApartament = 0;
        private int Id;
        private string descriere;
        private double suma;
        private DateTime dataEmitere;

        public DatorieApartament()
        {
            this.Id = Interlocked.Increment(ref _idDatorieApartament);
            this.dataEmitere = DateTime.Today;
        }

        public DatorieApartament(string descriere, double suma, DateTime dataEmitere)
        {
            this.descriere = descriere;
            this.suma = suma;
            this.dataEmitere = dataEmitere;
        }

        public string Descriere { get => descriere; set => descriere = value; }
        public double Suma { get => suma; set => suma = value; }
        public DateTime DataEmitere { get => dataEmitere; set => dataEmitere = value; }
        public int Id1 { get => Id; }
    }
}
