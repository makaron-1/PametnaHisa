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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private Klima klima;

        public Form6(Klima k)
        {
            InitializeComponent();
            klima = k;

            textBox1.Text = klima.temp.ToString();
        }

        /// <summary>
        /// Potrdi gumb posodobi nastavitve klime glede na vnešene vrednosti in zapre okno.
        /// Vnre sporočilo o uspešno posodobljenih nastavitvah.
        /// </summary>
        private void Potrdi_Click(object sender, EventArgs e)
        {
            klima.temp = int.Parse(textBox1.Text);
            if (mala.Checked)
            {
                klima.velikost_klime = "Majhna";
            }
            else if (Srednja.Checked)
            {
                klima.velikost_klime = "Srednja";
            }
            else
            {
                klima.velikost_klime = "Velika";
            }

            if (da.Checked)
            {
                klima.PoletnoHlajenje = true;

            }
            else
            {
                klima.PoletnoHlajenje = false;
            }
            this.Close();
        }
    }
}
