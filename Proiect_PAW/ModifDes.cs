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
    public partial class ModifDes : Form
    {
        Desfaceri d;
        List<Desfaceri> listadesfaceri = new List<Desfaceri>();

        public ModifDes(Desfaceri des)
        {
            InitializeComponent();
            d = des;

            if (d.modalitate.Length > 0)
            {
                cbModalitate.Text = d.modalitate;
                tbIncasariMin.Text = d.incasariMin.ToString();
                tbIncasariMax.Text = d.incasariMax.ToString();
                tbTva.Text = d.tva.ToString();
                tbLucratorCom.Text = d.lucratorcomercial;
            }
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            // Variabile pentru a valida datele
            bool isValid = true;
            string errorMessage = "";

            // Validare pentru fiecare câmp
            if (string.IsNullOrEmpty(cbModalitate.Text))
            {
                isValid = false;
                errorMessage += "Modalitatea nu poate fi goală.\n";
            }
            int incasariMin;
            if (!int.TryParse(tbIncasariMin.Text, out incasariMin) || incasariMin < 0)
            {
                isValid = false;
                errorMessage += "Incasările minime trebuie să fie un număr valid și mai mare sau egal cu 0.\n";
            }
            int incasariMax;
            if (!int.TryParse(tbIncasariMax.Text, out incasariMax) || incasariMax < 0)
            {
                isValid = false;
                errorMessage += "Incasările maxime trebuie să fie un număr valid și mai mare sau egal cu 0.\n";
            }
            double tva;
            if (!double.TryParse(tbTva.Text, out tva) || tva < 0)
            {
                isValid = false;
                errorMessage += "TVA-ul trebuie să fie un număr valid și mai mare sau egal cu 0.\n";
            }
            if (string.IsNullOrEmpty(tbLucratorCom.Text))
            {
                isValid = false;
                errorMessage += "Câmpul pentru lucrătorul comercial nu poate fi gol.\n";
            }

            // Dacă toate câmpurile sunt valide
            if (isValid)
            {
                // Aplică modificările obiectului 'd'
                d.modalitate = cbModalitate.Text;
                d.incasariMin = incasariMin;
                d.incasariMax = incasariMax;
                d.tva = tva;
                d.lucratorcomercial = tbLucratorCom.Text;

                // Afișează mesaj de succes
                MessageBox.Show("Modificările au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Închide fereastra și returnează OK ca rezultat
                DialogResult = DialogResult.OK;
            }
            else
            {
                // Dacă sunt erori, arată mesajul de eroare
                MessageBox.Show("Au apărut următoarele erori:\n" + errorMessage, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
