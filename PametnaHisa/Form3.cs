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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private Alarm alarm;

        public Form3(Alarm a)
        {
            InitializeComponent();
            alarm = a;

            textBox1.Text = alarm.glasnost.ToString();
        }

        /// <summary>
        /// Potrdi gumb posodobi nastavitve alarma glede na vnešene vrednosti in zapre okno. 
        /// Vrne sporočilo o uspešno posodobljenih nastavitvah.
        /// </summary>
        private void Potrdi_Click(object sender, EventArgs e)
        {
            alarm.glasnost = int.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                alarm.melodija = "Last christmast";
            }
            else if (radioButton2.Checked)
            {
                alarm.melodija = "Army";
            }
            else if (radioButton3.Checked)
            {
                alarm.melodija = "Jing Jang";
            }
            else if (radioButton4.Checked)
            {
                alarm.melodija = "Blue phonk";
            }
            else
            {
                alarm.melodija = "Default";
            }
            this.Close();
        }
    }
}
