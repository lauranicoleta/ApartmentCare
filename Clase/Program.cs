using ApartmentCare.Pagini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using ApartmentCare.Clase.PentruAsociatie;
using ApartmentCare.Clase;

namespace ApartmentCare
{
    internal static class Program
    {


        [STAThread]
        static void Main()
        {
            
            FirebaseManager firebaseManager = FirebaseManager.Instance;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PaginaConectare(firebaseManager.Client));
            

            Asociatie asoc1 = new Asociatie();
            MessageBox.Show(asoc1.CheieLicenta.ToString());
        }
    }
}
