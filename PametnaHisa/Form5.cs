using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RazrediNaprav;

namespace PametnaHisa
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private Roleta roleta;

        public Form5(Roleta r)
        {
            InitializeComponent();
            roleta = r;

            textBox1.Text = roleta.vrsta_rolete;
        }

        private void Potrdi_Click(object sender, EventArgs e)
        {
            roleta.vrsta_rolete = textBox1.Text;
            this.Close();
        }

        private void Spust_Click(object sender, EventArgs e)
        {
            MessageBox.Show(roleta.Spust_Rolete());
        }

        private void Dvig_Click(object sender, EventArgs e)
        {
            MessageBox.Show(roleta.Dvig_Rolete());
        }
    }
}
