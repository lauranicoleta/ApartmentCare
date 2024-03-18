using ApartmentCare.Clase.PentruApartament;
using ApartmentCare.Clase;
using ApartmentCare.Clase.PentruAsociatie;
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

namespace ApartmentCare.Pagini
{
    public partial class PaginaConectare : Form
    {
        private FireSharp.Interfaces.IFirebaseClient client;
        private List<Asociatie> asociatii = new List<Asociatie>();
        public PaginaConectare(FireSharp.Interfaces.IFirebaseClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void tbCheieLicenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btConectare_Click(object sender, EventArgs e)
        {
            if (this.client != null)
            {
                FirebaseResponse raspuns = await client.GetTaskAsync("asociatie/0");
                FirebaseResponse raspunsAdministrator = await client.GetTaskAsync("asociatie/0/administrator");
                FirebaseResponse raspunsCenzor = await client.GetTaskAsync("asociatie/0/cenzor");
                int i = 1;
                while (raspuns != null && raspuns.Body != "null" && raspunsAdministrator.Body != "null" && raspunsCenzor.Body != "null")
                {
                    Asociatie asociatie = raspuns.ResultAs<Asociatie>();
                    //MessageBox.Show(asociatie.CheieLicenta.ToString());
                    Administrator administrator = raspunsAdministrator.ResultAs<Administrator>();
                    asociatie.Administrator = administrator;
                    Cenzor cenzor = raspunsCenzor.ResultAs<Cenzor>();
                    asociatie.Cenzor = cenzor;
                    asociatii.Add(asociatie);
                    raspuns = await client.GetTaskAsync("asociatie/" + i);
                    raspunsAdministrator = await client.GetTaskAsync("asociatie/" + i + "/administrator");
                    raspunsCenzor = await client.GetTaskAsync("asociatie/" + i + "/cenzor");
                    i++;
                }
            }
            else
            {
                MessageBox.Show("Clientul Firebase nu este inițializat!");
            }
            foreach (var asociatie in asociatii)
            {
                if(asociatie.CheieLicenta == tbCheieLicenta.Text)
                {
                    if(asociatie.Administrator.Email == tbEmailConectare.Text || asociatie.Cenzor.Email == tbEmailConectare.Text)
                    {
                        if (asociatie.Administrator.Email == tbEmailConectare.Text && asociatie.Administrator.Parola == tbParolaConectare.Text)
                        {
                            MessageBox.Show("Conectat ca si Administrator pentru " + asociatie.Denumire + ".");
                            PaginaPrincipala paginaPrincipala = new PaginaPrincipala(client, asociatie.CheieLicenta);
                            paginaPrincipala.Show();
                            break;
                        }
                        else if (asociatie.Cenzor.Email == tbEmailConectare.Text && asociatie.Cenzor.Parola == tbParolaConectare.Text)
                        {
                            MessageBox.Show("Conectat ca si Cenzor pentru " + asociatie.Denumire + ".");
                            PaginaPrincipala paginaPrincipala = new PaginaPrincipala(client, asociatie.CheieLicenta);
                            paginaPrincipala.Show();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Parola nu este corecta!");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email-ul nu este corect!");
                        break;
                    }
                }
            }
        }
    }
}
