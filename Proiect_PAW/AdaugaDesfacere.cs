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
    public partial class AdaugaDesfacere : Form
    {
        private List<Desfaceri> listadesfaceri;

        // Constructor modificat pentru a accepta lista de desfaceri ca parametru
        public AdaugaDesfacere(List<Desfaceri> desfaceriList)
        {
            InitializeComponent();
            listadesfaceri = desfaceriList; // Initializeaza lista interna cu instanta primita
            this.FormClosing += AdaugaDesfacere_FormClosing; // Abonare la evenimentul FormClosing
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Desfaceri d = new Desfaceri();
            bool adaugaok = true;
            d.modalitate = cbModalitate.Text;
            try
            {
                d.incasariMin = Convert.ToInt32(tbIncasariMin.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Vă rugăm să introduceți un număr valid pentru Incasări Min!", "Eroare de conversie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            try
            {
                d.incasariMax = Convert.ToInt32(tbIncasariMax.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Vă rugăm să introduceți un număr valid pentru Incasări Max!", "Eroare de conversie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            try
            {
                d.tva = Convert.ToDouble(tbTva.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Vă rugăm să introduceți un număr valid pentru TVA!", "Eroare de conversie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            d.lucratorcomercial = tbLucratorCom.Text;
            if (adaugaok)
            {
                adaugaredesfacere(d);
            }
        }

        private void adaugaredesfacere(Desfaceri d)
        {
            listadesfaceri.Add(d);
            MessageBox.Show("Desfacerea a fost adăugată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Optional: Resetează controalele formularului
            cbModalitate.SelectedIndex = -1;
            tbIncasariMin.Clear();
            tbIncasariMax.Clear();
            tbTva.Clear();
            tbLucratorCom.Clear();
        }

        private void buttonVeziDesf_Click(object sender, EventArgs e)
        {
            Form vezidesf = new VeziDesfaceri(listadesfaceri); // Paseaza lista de desfaceri
            vezidesf.ShowDialog();
        }

        private void AdaugaDesfacere_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbModalitate.Text) ||
                !string.IsNullOrEmpty(tbIncasariMin.Text) ||
                !string.IsNullOrEmpty(tbIncasariMax.Text) ||
                !string.IsNullOrEmpty(tbTva.Text) ||
                !string.IsNullOrEmpty(tbLucratorCom.Text))
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