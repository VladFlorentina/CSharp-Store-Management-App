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
    public partial class AdaugaRaion : Form
    {
        private List<Raioane> listaraioane;

        // Constructor modificat pentru a accepta lista de raioane ca parametru
        public AdaugaRaion(List<Raioane> raioaneList)
        {
            InitializeComponent();
            listaraioane = raioaneList; // Initializeaza lista interna cu instanta primita
            this.FormClosing += AdaugaRaion_FormClosing; // Abonare la evenimentul FormClosing
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Raioane r = new Raioane();
            bool adaugaok = true;
            try
            {
                r.codRaion = Convert.ToInt32(tbCod.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Vă rugăm să introduceți un număr întreg valid pentru Cod Raion!", "Eroare de conversie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            r.denumire = tbDenumire.Text;
            r.sefRaion = tbSef.Text;

            if (adaugaok)
            {
                adaugareraion(r);
            }
        }

        private void adaugareraion(Raioane r)
        {
            listaraioane.Add(r);
            MessageBox.Show("Raionul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Optional: Resetează controalele formularului
            tbCod.Clear();
            tbDenumire.Clear();
            tbSef.Clear();
        }

        private void buttonVeziRaion_Click(object sender, EventArgs e)
        {
            Form vezirai = new VeziRaion(listaraioane); // Paseaza lista de raioane
            vezirai.ShowDialog();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdaugaRaion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCod.Text) ||
                !string.IsNullOrEmpty(tbDenumire.Text) ||
                !string.IsNullOrEmpty(tbSef.Text))
            {
                DialogResult result = MessageBox.Show("Aveți date neintroduse. Sigur doriți să închideți?", "Atenție", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Anuleaza inchiderea formularului
                }
            }
        }
    }
}