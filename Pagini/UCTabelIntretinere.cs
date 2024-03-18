using ApartmentCare.Clase;
using ApartmentCare.Clase.PentruApartament;
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
    public partial class UCTabelIntretinere : UserControl
    {
        private readonly FireSharp.Interfaces.IFirebaseClient client;
        private List<Apartament> apartamente = new List<Apartament>();
        private string cheielicenta;
        
        public UCTabelIntretinere(FireSharp.Interfaces.IFirebaseClient client, string cheieLicenta)
        {
            InitializeComponent();
            this.client = client;
            if(this.client == null )
            {
                MessageBox.Show("Client is null!");
            }
            else
            {
                MessageBox.Show("Client is not null!");
            }
            this.cheielicenta = cheieLicenta;
            dtGridView();

        }


        private void lvTabelintretinere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void dgListIntretinere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void dtGridView()
        {
            if (this.client != null)
            {
                FirebaseResponse cheieL = await client.GetTaskAsync("asociatie/cheieLicenta");
                string cheieLPrelucrata = cheieL.Body.Substring(1, cheieL.Body.Length - 2);
                MessageBox.Show(cheieLPrelucrata);
                if (cheieLPrelucrata.Equals(cheielicenta))
                {
                    FirebaseResponse raspuns = await client.GetTaskAsync("asociatie/apartamente/0");
                    int i = 1;
                    //
                        Apartament apartament = raspuns.ResultAs<Apartament>();
                        MessageBox.Show(apartament.NrApartament.ToString());
                        apartamente.Add(apartament);
                        raspuns = await client.GetTaskAsync("asociatie/apartamente/" + i);
                        i++;
                    //}
                }
            }
            else
            {
                MessageBox.Show("Clientul Firebase nu este inițializat!");
            }

            foreach(Apartament apt in apartamente)
            {
                if(apt != null)
                {
                    int rowIndex = dgListIntretinere.Rows.Add();
                    DataGridViewRow rand = dgListIntretinere.Rows[rowIndex];
                    rand.Cells[0].Value = apt.NrApartament;
                    FirebaseResponse raspuns = await client.GetTaskAsync("asociatie/apartamente/0/proprietar");
                    Proprietar proprietar = raspuns.ResultAs<Proprietar>();
                    apt.Proprietar = proprietar;
                    rand.Cells[1].Value = apt.Proprietar.Nume;
                }
            }
        }
    }
}
