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

    public partial class Meniu : Form
    {
        private List<Magazine> magazine = new List<Magazine>();
        private List<Desfaceri> desfaceri = new List<Desfaceri>();
        private List<Raioane> raioane = new List<Raioane>();

        public Meniu()
        {
            InitializeComponent();
        }

        private bool inapoiApasat = false;
        public bool InapoiApasat
        {
            get { return inapoiApasat; }
        }

        private void buttonMagazine_Click(object sender, EventArgs e)
        {
            AdaugaMagazin admag = new AdaugaMagazin(magazine); // Paseaza lista
            admag.FormClosed += (s, args) => this.Show();
            admag.Show();
            this.Hide();
        }

        private void buttonRaioane_Click(object sender, EventArgs e)
        {
            AdaugaRaion adrai = new AdaugaRaion(raioane); // Paseaza lista
            adrai.FormClosed += (s, args) => this.Show();
            adrai.Show();
            this.Hide();
        }

        private void buttonDesfaceri_Click(object sender, EventArgs e)
        {
            AdaugaDesfacere addes = new AdaugaDesfacere(desfaceri); // Paseaza lista
            addes.FormClosed += (s, args) => this.Show();
            addes.Show();
            this.Hide();
        }

        private void btnGrafice_Click(object sender, EventArgs e)
        {
            GraficeForm graficeForm = new GraficeForm(magazine, desfaceri, raioane);
            graficeForm.FormClosed += (s, args) => this.Show();
            graficeForm.Show();
            this.Hide();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            inapoiApasat = true;
            this.Close();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
