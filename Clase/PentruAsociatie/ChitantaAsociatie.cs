using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruAsociatie
{
    internal class ChitantaAsociatie
    {
        private string serie;
        private string tip;
        private DateTime dataChitantei;
        private string descriere;
        private double suma;
        private string serieDatorieAcoperita;
        private Boolean incasareInCont;

        public ChitantaAsociatie() { }
        public ChitantaAsociatie(string serie, string tip, DateTime dataChitantei, string descriere, 
            double suma,  string serieDatorieAcoperita, Boolean incasareInCon)
        {
            this.serie = serie;
            this.tip = tip;
            this.dataChitantei = dataChitantei;
            this.descriere = descriere;
            this.suma = suma;
            this.serieDatorieAcoperita = serieDatorieAcoperita;
            this.incasareInCont = incasareInCon;
        }

        public string Serie { get => serie; set => serie = value; }
        public string Tip { get => tip; set => tip = value; }
        public DateTime DataChitantei { get => dataChitantei; set => dataChitantei = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public double Suma { get => suma; set => suma = value; }
        public string SerieDatorieAcoperita { get => serieDatorieAcoperita; set => serieDatorieAcoperita = value; }
        public bool IncasareInCont { get => incasareInCont; set => incasareInCont = value; }

        public override string ToString()
        {
            return $"Serie: {Serie}, Tip: {Tip}, Data: {DataChitantei}, " +
                $"Descriere: {Descriere}, Suma: {Suma}, Serie Datorie Acoperita: {SerieDatorieAcoperita}, " +
                $"Incasare in Cont: {IncasareInCont}";
        }
    }
}
