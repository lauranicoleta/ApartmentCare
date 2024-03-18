using ApartmentCare.Clase;
using ApartmentCare.Pagini;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentCare
{
    public partial class PaginaPrincipala : Form
    {
        private readonly FireSharp.Interfaces.IFirebaseClient client;
        private string cheie;
        public PaginaPrincipala(FireSharp.Interfaces.IFirebaseClient client, string cheie)
        {
            InitializeComponent();
            this.client = client;
            this.cheie = cheie;
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
           // this.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PaginaPrincipala_Load(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelAfisaj_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btIntretinere_Click(object sender, EventArgs e)
        {
        //    if (client != null)
        //    {
        //        FirebaseResponse raspuns = await client.GetTaskAsync("asociatie/apartamente/0/contoare/0");
        //        if (raspuns != null && raspuns.Body != null) 
        //        {
        //            Contor contor = raspuns.ResultAs<Contor>();
        //            if (contor != null) 
        //            {
        //                MessageBox.Show(contor.ToString());
        //            }
        //            else
        //            {
        //                MessageBox.Show("Răspunsul de la server nu conține un obiect Contor valid.");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Răspunsul de la server este nul sau nu conține un corp de răspuns valid.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Clientul Firebase nu este inițializat!");
        //    }

            UCTabelIntretinere uCTabelIntretinere = new UCTabelIntretinere(client, cheie);
            panelAfisaj.Controls.Add(uCTabelIntretinere);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btExitConectare_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
