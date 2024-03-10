using ApartmentCare.Clase.PentruApartament;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruAsociatie
{
    internal class Asociatie
    {
        private string cui;
        private string denumire;
        private string adresa;
        private double soldCasa;
        private DateTime dataInfiintare;
        public List<Apartament> apartamente;
        public List<Furnizor> furnizori;
        public List<DatorieAsociatie> datoriiAsociatie;
        public List<ChitantaAsociatie> chitanteAsociatie;
        public List<ContBancar> conturiBancare;
        public List<RaspunsSesizare> raspunsuriSesizari;

        public string Cui { get => cui; set => cui = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public double SoldCasa { get => soldCasa; set => soldCasa = value; }
        public DateTime DataInfiintare { get => dataInfiintare; set => dataInfiintare = value; }

        public Asociatie() { }
        public Asociatie(string cui, string denumire, string adresa, double soldCasa, DateTime dataInfiintare, List<Apartament> apartamente, List<Furnizor> furnizori, List<DatorieAsociatie> datoriiAsociatie, List<ChitantaAsociatie> chitanteAsociatie, List<ContBancar> conturiBancare, List<RaspunsSesizare> raspunsuriSesizari)
        {
            this.cui = cui;
            this.denumire = denumire;
            this.adresa = adresa;
            this.soldCasa = soldCasa;
            this.dataInfiintare = dataInfiintare;
            this.apartamente = apartamente;
            this.furnizori = furnizori;
            this.datoriiAsociatie = datoriiAsociatie;
            this.chitanteAsociatie = chitanteAsociatie;
            this.conturiBancare = conturiBancare;
            this.raspunsuriSesizari = raspunsuriSesizari;
        }
    }
}
