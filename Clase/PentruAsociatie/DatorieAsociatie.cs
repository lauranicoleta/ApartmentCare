using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentCare.Clase.PentruAsociatie
{
    internal class DatorieAsociatie
    {
        private string serieFactura;
        private Furnizor furnizor;
        private string descriere;
        private double suma;
        private double sumaRamasaDeDistribuit;
        private DateTime dataEmitere;
        private DateTime dataScadenta;
        private Boolean plataDinFond;

        public DatorieAsociatie() { }

        public DatorieAsociatie(string serieFactura, Furnizor furnizor, 
            string descriere, double suma, DateTime dataEmitere, DateTime dataScadenta, 
            bool plataDinFond, double sumaRamasaDeDistribuit)
        {
            this.serieFactura = serieFactura;
            this.furnizor = furnizor;
            if (furnizor.DescriereImplicita != null)
            {
                this.descriere = furnizor.DescriereImplicita + " " + descriere;
            }
            else
            {
                this.descriere = descriere;
            }
            this.suma = suma;
            this.dataEmitere = dataEmitere;
            this.dataScadenta = dataScadenta;
            this.plataDinFond = plataDinFond;
            this.sumaRamasaDeDistribuit = sumaRamasaDeDistribuit;
        }

        public string SerieFactura { get => serieFactura; set => serieFactura = value; }
        public string Descriere { get => descriere; set
            {
                if (furnizor.DescriereImplicita != null)
                {
                    this.descriere = furnizor.DescriereImplicita + " " + descriere;
                }
                else
                {
                    this.descriere = descriere;
                }
            }
        }
        public double Suma { get => suma; set => suma = value; }
        public DateTime DataEmitere { get => dataEmitere; set => dataEmitere = value; }
        public DateTime DataScadenta { get => dataScadenta; set => dataScadenta = value; }
        public bool PlataDinFond { get => plataDinFond; set => plataDinFond = value; }
        public double SumaRamasaDeDistribuit { get => sumaRamasaDeDistribuit; set => sumaRamasaDeDistribuit = value; }
        internal Furnizor Furnizor { get => furnizor; set => furnizor = value; }

        public override string ToString()
        {
            return serieFactura + " " + descriere + " " + furnizor + " " + dataEmitere + " " + dataScadenta+
                " " + plataDinFond + " " + dataScadenta + " " + sumaRamasaDeDistribuit;
        }
    }
}
