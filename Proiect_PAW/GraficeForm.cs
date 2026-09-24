using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_PAW
{
    public partial class GraficeForm : Form
    {
        private List<Magazine> magazine;
        private List<Desfaceri> desfaceri;
        private List<Raioane> raioane;
        public GraficeForm(List<Magazine> magazine, List<Desfaceri> desfaceri, List<Raioane> raioane)
        {
            InitializeComponent();
            this.magazine = magazine != null ? magazine : new List<Magazine>();
            this.desfaceri = desfaceri != null ? desfaceri : new List<Desfaceri>();
            this.raioane = raioane != null ? raioane : new List<Raioane>();
            PopuleazaComboBox();
        }
        private void PopuleazaComboBox()
        {
            cbDate.Items.Clear();
            cbDate.Items.Add("Numar Magazine per Locatie");
            cbDate.Items.Add("Incasari Medii Desfaceri");
            cbDate.Items.Add("Numar Raioane per Denumire");
            cbDate.SelectedIndex = 0;
        }

        private void AfiseazaGrafic()
        {
            if (cbDate.SelectedItem == null) return;

            chartDate.Series.Clear();
            chartDate.ChartAreas.Clear();
            chartDate.ChartAreas.Add(new ChartArea("MainArea"));

            Series serie = new Series();
            chartDate.Series.Add(serie);

            string selectie = cbDate.SelectedItem.ToString();

            switch (selectie)
            {
                case "Numar Magazine per Locatie":
                    serie.ChartType = SeriesChartType.Bar;
                    var grupMagazine = magazine.GroupBy(m => m.locatie).Select(g => new { Locatie = g.Key, Numar = g.Count() });
                    foreach (var item in grupMagazine)
                        serie.Points.AddXY(item.Locatie, item.Numar);
                    break;

                case "Incasari Medii Desfaceri":
                    serie.ChartType = SeriesChartType.Pie;
                    var incasariMedii = desfaceri.Select(d => new { d.lucratorcomercial, IncasareMedie = d.CalculeazaIncasareMedie() });
                    foreach (var item in incasariMedii)
                        serie.Points.AddXY(item.lucratorcomercial, item.IncasareMedie);
                    break;

                case "Numar Raioane per Denumire":
                    serie.ChartType = SeriesChartType.Column;
                    var grupRaioane = raioane.GroupBy(r => r.denumire).Select(g => new { Denumire = g.Key, Numar = g.Count() });
                    foreach (var item in grupRaioane)
                        serie.Points.AddXY(item.Denumire, item.Numar);
                    break;
            }
        }


        private void btnBar_Click(object sender, EventArgs e)
        {
            if (chartDate.Series.Count > 0)
                chartDate.Series[0].ChartType = SeriesChartType.Bar;
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            if (chartDate.Series.Count > 0)
                chartDate.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void btnColumn_Click(object sender, EventArgs e)
        {
            if (chartDate.Series.Count > 0)
                chartDate.Series[0].ChartType = SeriesChartType.Column;
        }
        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfiseazaGrafic();
        }
    }
}
