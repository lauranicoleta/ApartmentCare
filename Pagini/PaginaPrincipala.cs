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
        public PaginaPrincipala()
        {
            InitializeComponent();
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
    }
}
