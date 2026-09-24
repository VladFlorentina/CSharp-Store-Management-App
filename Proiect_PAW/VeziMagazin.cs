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
using System.Drawing.Printing;


namespace Proiect_PAW
{
    public partial class VeziMagazin : Form
    {
        private ListViewItem draggedItem;

        public VeziMagazin(List<Magazine> listamagazine)
        {
            InitializeComponent();
            foreach (Magazine m in listamagazine)
            {
                ListViewItem lvi = new ListViewItem(m.idMagazin.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.denumire));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.locatie));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.program));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.nrAngajati.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, m.parcare));
                lvi.Tag = m;

                listViewMagazin.Items.Add(lvi);
            }
        }

        private void listViewMagazin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sf.FileName))
            {
                string fisier = sf.FileName;

                using (StreamWriter sw = new StreamWriter(fisier))
                {
                    foreach (ListViewItem lvi in listViewMagazin.Items)
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

        private void incarcaToolStripMenuItem_Click(object sender, EventArgs e)
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
            List<Magazine> lista = new List<Magazine>();

            try
            {
                using (StreamReader sr = new StreamReader(fisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            int idMagazin = Convert.ToInt32(parts[0].Trim());
                            string denumire = parts[1].Trim();
                            string locatie = parts[2].Trim();
                            string program = parts[3].Trim();
                            int nrAngajati = Convert.ToInt32(parts[4].Trim());
                            string parcare = parts[5].Trim();
                            lista.Add(new Magazine(idMagazin, denumire, locatie, program, nrAngajati, parcare));
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Linie invalidă în fișier: {0}", line), "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Eroare la citirea fișierului!");
                return; // Iese din metodă dacă apare o eroare
            }

            // Șterge elementele existente înainte de a le adăuga pe cele noi
            listViewMagazin.Items.Clear();

            foreach (Magazine m in lista)
            {
                ListViewItem lvi = new ListViewItem(m.idMagazin.ToString());
                lvi.SubItems.Add(m.denumire);
                lvi.SubItems.Add(m.locatie);
                lvi.SubItems.Add(m.program);
                lvi.SubItems.Add(m.nrAngajati.ToString());
                lvi.SubItems.Add(m.parcare);
                lvi.Tag = m;
                listViewMagazin.Items.Add(lvi);
            }
        }

        private void ștergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMagazin.SelectedItems.Count > 0)
            {
                listViewMagazin.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Selectati un rand pentru a sterge!");
            }
        }

        private void modificăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMagazin.SelectedItems.Count > 0)
            {
                Magazine m = (Magazine)listViewMagazin.SelectedItems[0].Tag;
                ModifMag mdf = new ModifMag(m);
                mdf.ShowDialog();

                if (mdf.DialogResult == DialogResult.OK)
                {
                    ListViewItem lvi = listViewMagazin.SelectedItems[0];
                    lvi.Text = m.idMagazin.ToString();
                    lvi.SubItems[1].Text = m.denumire;
                    lvi.SubItems[2].Text = m.locatie;
                    lvi.SubItems[3].Text = m.program;
                    lvi.SubItems[4].Text = m.nrAngajati.ToString();
                    lvi.SubItems[5].Text = m.parcare;
                }
            }
            else
            {
                MessageBox.Show("Selectati un rand pentru a modifica!");
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listViewMagazin.SelectedItems.Count > 0)
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


        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage -= PrintDocument_PrintPage;
                printDocument.PrintPage += PrintDocument_PrintPage;
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            Font printFont = this.listViewMagazin.Font;

            using (SolidBrush blackBrush = new SolidBrush(Color.Black))
            {
                // Imprimă antetele coloanelor
                foreach (ColumnHeader header in this.listViewMagazin.Columns)
                {
                    e.Graphics.DrawString(header.Text, printFont, blackBrush, leftMargin, yPos);
                    leftMargin += header.Width;
                }

                yPos += printFont.GetHeight();
                leftMargin = e.MarginBounds.Left;

                // Imprimă fiecare rând din ListView
                foreach (ListViewItem item in this.listViewMagazin.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        e.Graphics.DrawString(item.SubItems[i].Text, printFont, blackBrush, leftMargin, yPos);
                        leftMargin += this.listViewMagazin.Columns[i].Width;
                    }

                    yPos += printFont.GetHeight();
                    leftMargin = e.MarginBounds.Left;

                    // Dacă depășește pagina
                    if (yPos > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            }

            e.HasMorePages = false;
        }

        private void listViewMagazin_MouseDown(object sender, MouseEventArgs e)
        {
            // Asigură-te că s-a apăsat butonul stâng al mouse-ului
            if (e.Button == MouseButtons.Left)
            {
                // Obține elementul de sub cursor
                draggedItem = listViewMagazin.GetItemAt(e.X, e.Y);

                // Dacă s-a selectat un element, începe operațiunea de drag
                if (draggedItem != null)
                {
                    // Inițiază Drag & Drop. Transferăm elementul însuși ca date.
                    listViewMagazin.DoDragDrop(draggedItem, DragDropEffects.Move);
                }
            }
        }

        private void listViewMagazin_DragOver(object sender, DragEventArgs e)
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

        private void listViewMagazin_DragDrop(object sender, DragEventArgs e)
        {
            // Asigură-te că datele fixate sunt un ListViewItem
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                // Obține elementul fixat
                ListViewItem droppedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                // Obține punctul unde a fost fixat elementul (în coordonatele client ale ListView-ului)
                Point dropPoint = listViewMagazin.PointToClient(new Point(e.X, e.Y));

                // Obține indexul elementului de sub punctul de fixare
                ListViewItem targetItem = listViewMagazin.GetItemAt(dropPoint.X, dropPoint.Y);

                // Dacă s-a fixat pe un alt element (nu pe spațiul gol)
                if (targetItem != null && droppedItem != targetItem)
                {
                    // Obține indexul elementului tras și al elementului țintă
                    int droppedIndex = listViewMagazin.Items.IndexOf(droppedItem);
                    int targetIndex = listViewMagazin.Items.IndexOf(targetItem);

                    // Inserează elementul tras pe noua poziție
                    listViewMagazin.Items.RemoveAt(droppedIndex);
                    listViewMagazin.Items.Insert(targetIndex, droppedItem);
                }
                // Dacă s-a fixat pe spațiul gol, adaugă-l la sfârșit
                else if (targetItem == null)
                {
                    listViewMagazin.Items.Remove(droppedItem);
                    listViewMagazin.Items.Add(droppedItem);
                }
            }
        }
    }
}