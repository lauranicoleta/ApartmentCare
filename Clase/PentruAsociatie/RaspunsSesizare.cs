using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruAsociatie
{
    internal class RaspunsSesizare
    {
        private static int _idRaspunsSesizare = 0;
        private int Id;
        private int idSesizare;
        private string text;
        private DateTime dataRaspuns;
    
        public RaspunsSesizare()
        {
            this.Id = Interlocked.Increment(ref _idRaspunsSesizare);
            this.dataRaspuns = DateTime.Today;
        }
        public RaspunsSesizare(int idSesizare, string text, DateTime dataRaspuns)
        {
            this.idSesizare = idSesizare;
            this.text = text;
            this.dataRaspuns = dataRaspuns;
        }

        public int Id1 { get => Id; }
        public int IdSesizare { get => idSesizare; set => idSesizare = value; }
        public string Text { get => text; set => text = value; }
    }
}
