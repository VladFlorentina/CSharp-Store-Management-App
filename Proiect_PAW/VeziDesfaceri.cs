using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class VeziDesfaceri : Form
    {
        private ListViewItem draggedItem; // DECLARĂ ACEASTĂ VARIABILĂ CA MEMBRU AL CLASEI

        public VeziDesfaceri(List<Desfaceri> listadesfaceri)
        {
            InitializeComponent();
            foreach (Desfaceri d in listadesfaceri)
            {
                ListViewItem lvi = new ListViewItem(d.modalitate);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMin.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMax.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.tva.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.lucratorcomercial));
                lvi.Tag = d;

                listViewDesfaceri.Items.Add(lvi);
            }
        }

        private void listViewDesfaceri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void încarcăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(fd.FileName))
            {
                string fisier = fd.FileName;
                CitesteDate(fisier);
            }
        }

        private void CitesteDate(string fisier)
        {
            List<Desfaceri> lista = new List<Desfaceri>();

            try
            {
                using (StreamReader sr = new StreamReader(fisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            string modalitate = parts[0].Trim();
                            int incasariMin = Convert.ToInt32(parts[1].Trim());
                            int incasariMax = Convert.ToInt32(parts[2].Trim());
                            double tva = Convert.ToDouble(parts[3].Trim());
                            string lucratorcomercial = parts[4].Trim();
                            lista.Add(new Desfaceri(modalitate, incasariMin, incasariMax, tva, lucratorcomercial));
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Eroare la citirea fișierului!");
                return;
            }

            foreach (Desfaceri d in lista)
            {
                ListViewItem lvi = new ListViewItem(d.modalitate);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMin.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.incasariMax.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.tva.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, d.lucratorcomercial));
                lvi.Tag = d;

                listViewDesfaceri.Items.Add(lvi);
            }
        }

        private void salveazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sf.FileName))
            {
                string fisier = sf.FileName;

                using (StreamWriter sw = new StreamWriter(fisier))
                {
                    foreach (ListViewItem lvi in listViewDesfaceri.Items)
                    {
                        for (int i = 0; i < lvi.SubItems.Count; i++)
                        {
                            sw.Write(lvi.SubItems[i].Text);
                            if (i != lvi.SubItems.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }
                MessageBox.Show("Fisierul s-a salvat ca: " + fisier);
            }
        }

        private void ștergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewDesfaceri.SelectedItems.Count > 0)
            {
                listViewDesfaceri.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Selectati un rand pentru a sterge!");
            }
        }

        private void modificăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewDesfaceri.SelectedItems.Count > 0)
            {
                Desfaceri d = (Desfaceri)listViewDesfaceri.SelectedItems[0].Tag;
                ModifDes mdf = new ModifDes(d);
                mdf.ShowDialog();

                if (mdf.DialogResult == DialogResult.OK)
                {
                    ListViewItem lvi = listViewDesfaceri.SelectedItems[0];
                    lvi.Text = d.modalitate;
                    lvi.SubItems[1].Text = d.incasariMin.ToString();
                    lvi.SubItems[2].Text = d.incasariMax.ToString();
                    lvi.SubItems[3].Text = d.tva.ToString();
                    lvi.SubItems[4].Text = d.lucratorcomercial;
                }
            }
            else
            {
                MessageBox.Show("Selectati un rand pentru a modifica!");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewDesfaceri.SelectedItems.Count > 0)
            {
                modificăToolStripMenuItem.Enabled = true;
                ștergeToolStripMenuItem.Enabled = true;
            }
            else
            {
                modificăToolStripMenuItem.Enabled = false;
                ștergeToolStripMenuItem.Enabled = false;
                e.Cancel = true;
            }
        }

        private void listViewDesfaceri_MouseDown(object sender, MouseEventArgs e)
        {
            // Asigură-te că s-a apăsat butonul stâng al mouse-ului
            if (e.Button == MouseButtons.Left)
            {
                // Obține elementul de sub cursor
                draggedItem = listViewDesfaceri.GetItemAt(e.X, e.Y);

                // Dacă s-a selectat un element, începe operațiunea de drag
                if (draggedItem != null)
                {
                    // Inițiază Drag & Drop. Transferăm elementul însuși ca date.
                    listViewDesfaceri.DoDragDrop(draggedItem, DragDropEffects.Move);
                }
            }

        }

        private void VeziDesfaceri_DragOver(object sender, DragEventArgs e)
        {
            // Verifică dacă datele care sunt trase sunt un ListViewItem
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                // Permite efectul de mutare (schimbarea ordinii)
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // Dacă nu sunt datele potrivite, nu permite drop-ul
                e.Effect = DragDropEffects.None;
            }
        }

        private void VeziDesfaceri_DragDrop(object sender, DragEventArgs e)
        {
            // Asigură-te că datele fixate sunt un ListViewItem
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                // Obține elementul fixat
                ListViewItem droppedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                // Obține punctul unde a fost fixat elementul (în coordonatele client ale ListView-ului)
                Point dropPoint = listViewDesfaceri.PointToClient(new Point(e.X, e.Y));

                // Obține indexul elementului de sub punctul de fixare
                ListViewItem targetItem = listViewDesfaceri.GetItemAt(dropPoint.X, dropPoint.Y);

                // Dacă s-a fixat pe un alt element (nu pe spațiul gol)
                if (targetItem != null && droppedItem != targetItem)
                {
                    // Obține indexul elementului tras și al elementului țintă
                    int droppedIndex = listViewDesfaceri.Items.IndexOf(droppedItem);
                    int targetIndex = listViewDesfaceri.Items.IndexOf(targetItem);

                    // Inserează elementul tras pe noua poziție
                    listViewDesfaceri.Items.RemoveAt(droppedIndex);
                    listViewDesfaceri.Items.Insert(targetIndex, droppedItem);
                }
                // Dacă s-a fixat pe spațiul gol, adaugă-l la sfârșit
                else if (targetItem == null)
                {
                    listViewDesfaceri.Items.Remove(droppedItem);
                    listViewDesfaceri.Items.Add(droppedItem);
                }
            }
        }
    }
}