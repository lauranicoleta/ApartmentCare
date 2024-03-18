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
        private string cheieLicenta;
        private string cui;
        private string denumire;
        private string adresa;
        private double soldCasa;
        private DateTime dataInfiintare;
        private Administrator administrator;
        private Cenzor cenzor;
        public List<Apartament> apartamente;
        public List<Furnizor> furnizori;
        public List<DatorieAsociatie> datoriiAsociatie;
        public List<ChitantaAsociatie> chitanteAsociatie;
        public List<ContBancar> conturiBancare;
        private List<Fond> fonduri;
        public List<RaspunsSesizare> raspunsuriSesizari;

        public string Cui { get => cui; set => cui = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public double SoldCasa { get => soldCasa; set => soldCasa = value; }
        public DateTime DataInfiintare { get => dataInfiintare; set => dataInfiintare = value; }
        internal Administrator Administrator { get => administrator; set => administrator = value; }
        internal Cenzor Cenzor { get => cenzor; set => cenzor = value; }
        public string CheieLicenta { get => cheieLicenta; set => cheieLicenta = value; }
        internal List<Fond> Fonduri { get => fonduri; set => fonduri = value; }

        public Asociatie() {
            this.cheieLicenta = generareCheieLicenta();
        }
        public Asociatie(string cui, string denumire, string adresa, double soldCasa, DateTime dataInfiintare, 
            Administrator administrator, Cenzor cenzor, List<Apartament> apartamente, List<Furnizor> furnizori, 
            List<DatorieAsociatie> datoriiAsociatie, List<ChitantaAsociatie> chitanteAsociatie, 
            List<ContBancar> conturiBancare, List<Fond> fonduri,
            List<RaspunsSesizare> raspunsuriSesizari)
        {
            this.cui = cui;
            this.denumire = denumire;
            this.adresa = adresa;
            this.soldCasa = soldCasa;
            this.dataInfiintare = dataInfiintare;
            this.administrator = administrator;
            this.cenzor = cenzor;
            this.apartamente = apartamente;
            this.furnizori = furnizori;
            this.datoriiAsociatie = datoriiAsociatie;
            this.chitanteAsociatie = chitanteAsociatie;
            this.conturiBancare = conturiBancare;
            this.fonduri = fonduri;
            this.raspunsuriSesizari = raspunsuriSesizari;
        }

        private string generareCheieLicenta()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var cheie = new StringBuilder();

            for (int i = 0; i < 12; i++)
            {
                int index = random.Next(chars.Length);
                cheie.Append(chars[index]);
            }

            return cheie.ToString();
        }
    }
}
