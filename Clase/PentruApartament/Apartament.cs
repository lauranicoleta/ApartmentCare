using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruApartament
{
    internal class Apartament
    {
        private int nrApartament;
        private float suprefataTotala;
        private float suprafataUtila;
        private float cotaParte;
        private int nrCamere;
        private float altParametru;
        private int nrPersoane;
        private double soldFondReparatii;
        private double soldFondRulment;
        private double soldFonduriSpeciale;
        private double restantaIntretinere;
        private double restantaFonduri;
        private double penalizare;
        private Proprietar proprietar;
        public List<Contor> contoare;
        public List<ChitantaApartament> chitanteApartament;
        public List<DatorieApartament> datoriiApartament;

        public Apartament(){ }

        public Apartament(int nrApartament, float suprefataTotala, float suprafataUtila, 
            float cotaParte, int nrCamere, float altParametru, int nrPersoane, double soldFondReparatii, double soldFondRulment, 
            double soldFonduriSpeciale, double restantaIntretinere, double restantaFonduri, 
            double penalizare, Proprietar proprietar, List<Contor> contoare, 
            List<ChitantaApartament> chitanteApartament, List<DatorieApartament> datoriiApartament)
        {
            this.nrApartament = nrApartament;
            this.suprefataTotala = suprefataTotala;
            this.suprafataUtila = suprafataUtila;
            this.cotaParte = cotaParte;
            this.nrCamere = nrCamere;
            this.altParametru = altParametru;
            this.nrPersoane = nrPersoane;
            this.soldFondReparatii = soldFondReparatii;
            this.soldFondRulment = soldFondRulment;
            this.soldFonduriSpeciale = soldFonduriSpeciale;
            this.restantaIntretinere = restantaIntretinere;
            this.restantaFonduri = restantaFonduri;
            this.penalizare = penalizare;
            this.proprietar = proprietar;
            this.contoare = contoare;
            this.chitanteApartament = chitanteApartament;
            this.datoriiApartament = datoriiApartament;
        }


        public int NrApartament { get => nrApartament; set => nrApartament = value; }
        public float SuprefataTotala { get => suprefataTotala; set => suprefataTotala = value; }
        public float SuprafataUtila { get => suprafataUtila; set => suprafataUtila = value; }
        public float CotaParte { get => cotaParte; set => cotaParte = value; }
        public int NrCamere { get => nrCamere; set => nrCamere = value; }
        public float AltParametru { get => altParametru; set => altParametru = value; }
        public int NrPersoane { get => nrPersoane; set => nrPersoane = value; }
        public double SoldFondReparatii { get => soldFondReparatii; set => soldFondReparatii = value; }
        public double SoldFondRulment { get => soldFondRulment; set => soldFondRulment = value; }
        public double SoldFonduriSpeciale { get => soldFonduriSpeciale; set => soldFonduriSpeciale = value; }
        public double RestantaIntretinere { get => restantaIntretinere; set => restantaIntretinere = value; }
        public double RestantaFonduri { get => restantaFonduri; set => restantaFonduri = value; }
        public double Penalizare { get => penalizare; set => penalizare = value; }
        internal Proprietar Proprietar { get => proprietar; set => proprietar = value; }
    }
}
