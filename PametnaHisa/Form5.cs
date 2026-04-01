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

        /// <summary>
        /// Potrdi gumb posodobi nastavitve rolete glede na vnešene vrednosti in zapre okno.
        /// Vrne sporočilo o uspešno posodobljenih nastavitvah.
        /// </summary>
        private void Potrdi_Click(object sender, EventArgs e)
        {
            roleta.vrsta_rolete = textBox1.Text;
            this.Close();
        }

        /// <summary>
        /// Vrne sporočilo o spustu rolete.
        /// </summary>
        private void Spust_Click(object sender, EventArgs e)
        {
            MessageBox.Show(roleta.Spust_Rolete());
        }

        /// <summary>
        /// Vrne sporočilo o dvigu rolete.
        /// </summary>
        private void Dvig_Click(object sender, EventArgs e)
        {
            MessageBox.Show(roleta.Dvig_Rolete());
        }
    }
}
