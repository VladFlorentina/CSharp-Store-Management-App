using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class ModifRai : Form
    {
        Raioane r;
        List<Raioane> listaraioane = new List<Raioane>();

        public ModifRai(Raioane rai)
        {
            InitializeComponent();
            r = rai;

            if (r.denumire.Length > 0)
            {
                tbCod.Text = r.codRaion.ToString();
                tbDenumire.Text = r.denumire;
                tbSef.Text = r.sefRaion;
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            r.codRaion = Convert.ToInt32(tbCod.Text);
            r.denumire = tbDenumire.Text;
            r.sefRaion = tbSef.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
