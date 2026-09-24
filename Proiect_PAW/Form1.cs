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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIncepe_Click(object sender, EventArgs e)
        {
            Meniu menu = new Meniu();
            menu.FormClosed += (s, args) =>
            {
                if (menu.InapoiApasat)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            };
            menu.Show();
            this.Hide(); //ascunde formularul Form1 la apasarea butonului;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbRegistru_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
