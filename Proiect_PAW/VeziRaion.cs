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
    public partial class VeziRaion : Form
    {
        private ListViewItem draggedItem; // DECLARAȚIA AICI, CA MEMBRU AL CLASEI

        public VeziRaion(List<Raioane> listaraiaone)
        {
            InitializeComponent();
            foreach (Raioane r in listaraiaone)
            {
                ListViewItem lvi = new ListViewItem(r.codRaion.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.denumire));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.sefRaion));
                lvi.Tag = r;

                listViewRaion.Items.Add(lvi);

            }
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
            List<Raioane> lista = new List<Raioane>();

            try
            {
                using (StreamReader sr = new StreamReader(fisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            int codRaion = Convert.ToInt32(parts[0].Trim());
                            string denumire = parts[1].Trim();
                            string sefRaion = parts[2].Trim();
                            lista.Add(new Raioane(codRaion, denumire, sefRaion));
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Eroare la citirea fișierului!");
                return;
            }

            foreach (Raioane r in lista)
            {
                ListViewItem lvi = new ListViewItem(r.codRaion.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.denumire));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, r.sefRaion));
                lvi.Tag = r;

                listViewRaion.Items.Add(lvi);
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
                    foreach (ListViewItem lvi in listViewRaion.Items)
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
            if (listViewRaion.SelectedItems.Count > 0)
            {
                listViewRaion.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Selectati un rand pentru a sterge!");
            }
        }

        private void modificăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewRaion.SelectedItems.Count > 0)
            {
                Raioane r = (Raioane)listViewRaion.SelectedItems[0].Tag;
                ModifRai mdf = new ModifRai(r);
                mdf.ShowDialog();

                if (mdf.DialogResult == DialogResult.OK)
                {
                    ListViewItem lvi = listViewRaion.SelectedItems[0];
                    lvi.Text = r.codRaion.ToString();
                    lvi.SubItems[1].Text = r.denumire;
                    lvi.SubItems[2].Text = r.sefRaion;
                }
            }
            else
            {
                MessageBox.Show("Selectati un rand pentru a modifica!");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewRaion.SelectedItems.Count > 0)
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

        private void VeziRaion_MouseDown(object sender, MouseEventArgs e)
        {
            // Asigură-te că s-a apăsat butonul stâng al mouse-ului
            if (e.Button == MouseButtons.Left)
            {
                // Obține elementul de sub cursor
                draggedItem = listViewRaion.GetItemAt(e.X, e.Y);

                // Dacă s-a selectat un element, începe operațiunea de drag
                if (draggedItem != null)
                {
                    // Inițiază Drag & Drop. Transferăm elementul însuși ca date.
                    listViewRaion.DoDragDrop(draggedItem, DragDropEffects.Move);
                }
            }
        }

        private void listViewRaion_DragOver(object sender, DragEventArgs e)
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

        private void listViewRaion_DragDrop(object sender, DragEventArgs e)
        {
            // Asigură-te că datele fixate sunt un ListViewItem
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                // Obține elementul fixat
                ListViewItem droppedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                // Obține punctul unde a fost fixat elementul (în coordonatele client ale ListView-ului)
                Point dropPoint = listViewRaion.PointToClient(new Point(e.X, e.Y));

                // Obține indexul elementului de sub punctul de fixare
                ListViewItem targetItem = listViewRaion.GetItemAt(dropPoint.X, dropPoint.Y);

                // Dacă s-a fixat pe un alt element (nu pe spațiul gol)
                if (targetItem != null && droppedItem != targetItem)
                {
                    // Obține indexul elementului tras și al elementului țintă
                    int droppedIndex = listViewRaion.Items.IndexOf(droppedItem);
                    int targetIndex = listViewRaion.Items.IndexOf(targetItem);

                    // Inserează elementul tras pe noua poziție
                    listViewRaion.Items.RemoveAt(droppedIndex);
                    listViewRaion.Items.Insert(targetIndex, droppedItem);
                }
                // Dacă s-a fixat pe spațiul gol, adaugă-l la sfârșit (poți modifica această logică)
                else if (targetItem == null)
                {
                    listViewRaion.Items.Remove(droppedItem);
                    listViewRaion.Items.Add(droppedItem);
                }
            }
        }
    }
}