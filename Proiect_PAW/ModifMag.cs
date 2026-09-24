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
    public partial class ModifMag : Form
    {
        Magazine m;
        List<Magazine> listamagazine = new List<Magazine>();

        public ModifMag(Magazine mag)
        {
            InitializeComponent();
            m = mag;

            if (m.denumire.Length > 0)
            {
                tbID.Text = m.idMagazin.ToString();
                tbDenumire.Text = m.denumire;
                tbLocatie.Text = m.locatie;
                tbProgram.Text = m.program;
                tbNrAng.Text = m.nrAngajati.ToString();
                cbParcare.Text = m.parcare;
            }
            
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {

            m.idMagazin = Convert.ToInt32(tbID.Text);
            m.denumire = tbDenumire.Text;
            m.locatie = tbLocatie.Text;
            m.program = tbProgram.Text;
            m.nrAngajati = Convert.ToInt32(tbNrAng.Text);
            m.parcare = cbParcare.Text;

            DialogResult = DialogResult.OK;

        }
    }
}
