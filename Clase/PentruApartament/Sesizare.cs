using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruApartament
{
    internal class Sesizare
    {
        private static int _idSesizare = 0;
        private int Id;
        private string text;
        private DateTime dataSesizarii;

        public Sesizare()
        {
            this.Id = Interlocked.Increment(ref _idSesizare);
            this.dataSesizarii = DateTime.Today;
        }

        public Sesizare(string text, DateTime dataSesizarii)
        {
            this.text = text;
            this.dataSesizarii = dataSesizarii;
        }

        public int Id1 { get => Id; }
        public string Text { get => text; set => text = value; }
        public DateTime DataSesizarii { get => dataSesizarii; set => dataSesizarii = value; }
    }
}
