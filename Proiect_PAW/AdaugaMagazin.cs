using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_PAW
{
    public partial class AdaugaMagazin : Form
    {
        private List<Magazine> listamagazine;

        // Constructor modificat pentru a accepta lista de magazine ca parametru
        public AdaugaMagazin(List<Magazine> magazineList)
        {
            InitializeComponent();
            listamagazine = magazineList; // Initializeaza lista interna cu instanta primita
            this.FormClosing += AdaugaMagazin_FormClosing; // Abonare la evenimentul FormClosing
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine();
            bool adaugaok = true;
            try
            {
                m.idMagazin = Convert.ToInt32(tbID.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Vă rugăm să introduceți un număr întreg valid pentru ID Magazin!", "Eroare de conversie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            m.denumire = tbDenumire.Text;
            m.locatie = tbLocatie.Text;
            m.program = tbProgram.Text;
            try
            {
                m.nrAngajati = Convert.ToInt32(tbNrAng.Text);
            }
            catch
            {
                adaugaok = false;
                MessageBox.Show("Vă rugăm să introduceți un număr întreg valid pentru Număr Angajați!", "Eroare de conversie", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            m.parcare = cbParcare.Text;

            //ERROR PROVIDER;
            if (string.IsNullOrEmpty(tbDenumire.Text)) // Verificare daca string-ul este null sau empty
            {
                tbDenumire.Focus();
                errorProvider1.SetError(tbDenumire, "Completează câmpul denumire!");
                adaugaok = false;
            }
            else
            {
                errorProvider1.SetError(tbDenumire, ""); // Sterge eroarea daca campul este valid
            }

            if (adaugaok)
            {
                adaugaremagazin(m);
            }
        }

        private void adaugaremagazin(Magazine m)
        {
            listamagazine.Add(m);
            MessageBox.Show("Magazinul a fost adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Optional: Resetează controalele formularului
            tbID.Clear();
            tbDenumire.Clear();
            tbLocatie.Clear();
            tbProgram.Clear();
            tbNrAng.Clear();
            cbParcare.SelectedIndex = -1;
        }

        private void buttonVeziMagazin_Click(object sender, EventArgs e)
        {
            Form vezimag = new VeziMagazin(listamagazine); // Paseaza lista de magazine
            vezimag.ShowDialog();
        }

        private void AdaugaMagazin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbID.Text) ||
                !string.IsNullOrEmpty(tbDenumire.Text) ||
                !string.IsNullOrEmpty(tbLocatie.Text) ||
                !string.IsNullOrEmpty(tbProgram.Text) ||
                !string.IsNullOrEmpty(tbNrAng.Text) ||
                cbParcare.SelectedIndex != -1)
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