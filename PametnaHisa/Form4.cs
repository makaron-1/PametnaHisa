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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private Termostat termostat;

        public Form4(Termostat t)
        {
            InitializeComponent();
            termostat = t;

            textBox1.Text = termostat.temperatura.ToString();
        }

        private void Potrdi_Click(object sender, EventArgs e)
        {
            termostat.temperatura = int.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                termostat.Temp_Mode = "Cold";
            }
            else
            {
                termostat.Temp_Mode = "Hot";
            }
            this.Close();
        }
    }
}
