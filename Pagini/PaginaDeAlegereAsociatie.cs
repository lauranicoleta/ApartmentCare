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
    public partial class PaginaDeAlegereAsociatie : Form
    {
        public PaginaDeAlegereAsociatie()
        {
            InitializeComponent();
            infoFunctieDrepturi.SetToolTip(tbFunctieDrepturi, "Funcția de Administrator oferă posibilitatea prelucrării datelor, \r\nîn timp ce cea de cenzor oferă strict vizualizarea lor fară drept \r\nde modificare.");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tbFunctieDrepturi_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAfisaj_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btExitConectare_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbAsociatiiDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {

      

        }
    }
}
