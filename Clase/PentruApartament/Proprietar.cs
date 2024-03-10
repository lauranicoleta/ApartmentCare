using ApartmentCare.Clase.PentruApartament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApartmentCare.Clase
{
    internal class Proprietar
    {
        private static int _idProprietar = 0;
        private int Id { get; }

        private string nume;
        private string parola;

        private List<Sesizare> sesizari;

        public Proprietar()
        {
        }

        public Proprietar(int id, string nume, string parola, List<Sesizare> sesizari)
        {
            this.Id=Interlocked.Increment(ref _idProprietar);
            this.nume = nume;
            this.parola = parola;
            this.sesizari = sesizari;
        }

        public string Nume { get => nume; set => nume = value; }
        public string Parola { get => parola; set => parola = value; }
        internal List<Sesizare> Sesizari { get => sesizari; set => sesizari = value; }
    }
}
