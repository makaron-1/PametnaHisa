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
    public partial class Form2 : Form
    {
        private Naprave trenutnaNaprava;
        public Form2()
        {
            InitializeComponent();
        }

        private Luc luc;

        public Form2(Luc l)
        {
            InitializeComponent();
            luc = l;

            textBox1.Text = luc.moc_svetlosti.ToString();
            vrstaZarnice.Text = luc.vrsta_zarnice;
            if (da.Checked) luc.dim_mode = true;
            else luc.dim_mode = false;
        }

        /// <summary>
        /// Potrdi gumb posodobi nastavitve luči glede na vnešene vrednosti in zapre okno. 
        /// Vrne sporočilo o uspešno posodobljenih nastavitvah.
        /// </summary>
        private void Potrdi_Click(object sender, EventArgs e)
        {
            luc.moc_svetlosti = int.Parse(textBox1.Text);
            luc.vrsta_zarnice = vrstaZarnice.Text;
            if (da.Checked) luc.dim_mode = true;
            else luc.dim_mode = false;

            MessageBox.Show("Settings updated!");
            this.Close();
        }
    }
}
