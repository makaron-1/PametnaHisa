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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Microsoft.VisualBasic;

namespace PametnaHisa
{
    public partial class Form1 : Form
    {
        SeznamNaprav seznamNaprav = new SeznamNaprav();
        private Naprave trenutnaNaprava;
        public Form1()
        {
            InitializeComponent();
        }

        private void Stevilo_TextChanged(object sender, EventArgs e)
        {
            Stevilo.Text = Naprave.VrniSteviloNaprav().ToString();
        }

        /// <summary>
        /// Ustvari novo napravo glede na izbran tip in jo doda v seznam. Vrne sporočilo, da je bila naprava uspešno ustvarjena. 
        /// Nato se naroči na dogodek OnStatusChanged, da se vsaka sprememba stanja naprave zabeleži v listBox1. Če je izbran Alarm, se naroči tudi na dogodek AlarmTriggered, ki prikaže sporočilo, ko je alarm sprožen.
        /// Na koncu se posodobi prikaz števila naprav.
        /// </summary>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;

            if (Luc.Checked)
            {
                trenutnaNaprava = new Luc(ime, "LED", 0, "NE");
                trenutnaNaprava.OnStatusChanged += (napravaObj, msg) =>
                {
                    listBox1.Items.Add(msg);
                };
                MessageBox.Show("Luč ustvarjena.");
                seznamNaprav.Dodaj(trenutnaNaprava);
            }
            else if (Alarm.Checked)
            {
                trenutnaNaprava = new Alarm(ime, 0, "");
                Alarm alarm = (Alarm)trenutnaNaprava;

                alarm.AlarmTriggered += (s, ev) =>
                {
                    MessageBox.Show("ALARM SPROŽEN!");
                    listBox1.Items.Add("ALARM sprožen!");
                };
                trenutnaNaprava.OnStatusChanged += (napravaObj, msg) =>
                {
                    listBox1.Items.Add(msg);
                };
                MessageBox.Show("Alarm je ustvarjen.");
                seznamNaprav.Dodaj(trenutnaNaprava);
            }
            else if (Termostat.Checked)
            {
                trenutnaNaprava = new Termostat(ime, 0, "");
                Termostat t = (Termostat)trenutnaNaprava;

                t.TemperaturaChanged += (temp) =>
                {
                    textBox1.Text = $"{temp} °C";

                    if (temp > 30)
                        textBox1.BackColor = Color.Red;
                    else if (temp < 10)
                        textBox1.BackColor = Color.LightBlue;
                    else
                        textBox1.BackColor = Color.White;
                };
                trenutnaNaprava.OnStatusChanged += (napravaObj, msg) =>
                {
                    listBox1.Items.Add(msg);
                };
                MessageBox.Show("Termostat je ustvarjen.");
                seznamNaprav.Dodaj(trenutnaNaprava);
            }
            else if (Roleta.Checked)
            {
                trenutnaNaprava = new Roleta(ime, "");
                trenutnaNaprava.OnStatusChanged += (napravaObj, msg) =>
                {
                    listBox1.Items.Add(msg);
                };
                MessageBox.Show("Roleta je ustvarjen.");
                seznamNaprav.Dodaj(trenutnaNaprava);
            }
            else
            {
                trenutnaNaprava = new Klima(ime, 0, "", "NE");
                trenutnaNaprava.OnStatusChanged += (napravaObj, msg) =>
                {
                    listBox1.Items.Add(msg);
                };
                MessageBox.Show("Roleta je ustvarjen.");
                seznamNaprav.Dodaj(trenutnaNaprava);
            }
            Stevilo.Text = Naprave.VrniSteviloNaprav().ToString()+"W";
        }

        /// <summary>
        /// Odpre nastavitve naprave po preverjanju gesla. 
        /// Če je naprava zaščitena z geslom, se odpre dialog za vnos gesla. 
        /// Če je geslo pravilno, se odprejo nastavitve naprave glede na njen tip (Luc, Alarm, Termostat, Roleta ali Klima). 
        /// Po zaprtju nastavitev se posodobi prikaz temperature, če je naprava termostat ali klima.
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (trenutnaNaprava == null)
            {
                MessageBox.Show("Najprej izberi napravo!");
                return;
            }

            if (trenutnaNaprava is IVarnost varnost)
            {
                using (FormGeslo fg = new FormGeslo())
                {
                    if (fg.ShowDialog() != DialogResult.OK)
                        return;

                    if (!varnost.VnesiGeslo(fg.VnesenoGeslo))
                    {
                        MessageBox.Show("Napačno geslo!");
                        return;
                    }
                }
            }

            if (trenutnaNaprava is Luc luc)
            {
                Form2 settingsLuc = new Form2(luc);
                settingsLuc.ShowDialog();
            }
            else if (trenutnaNaprava is Alarm a)
            {
                Form3 settingsAlarm = new Form3(a);
                settingsAlarm.ShowDialog();

            }
            else if (trenutnaNaprava is Termostat t)
            {
                Form4 settingsTermostat = new Form4(t);
                settingsTermostat.ShowDialog();
            }
            else if (trenutnaNaprava is Roleta r)
            {
                Form5 settingsRoleta = new Form5(r);
                settingsRoleta.ShowDialog();
            }
            else
            {
                Form6 settingsKlima = new Form6();
                settingsKlima.ShowDialog();
            }
            if (trenutnaNaprava is ITemperaturnaNaprava temp)
            {
                textBox1.Text = temp.IzpisTemparature() + " °C";
            }
        }

        /// <summary>
        /// Vklopi trenutno napravo in prikaže porabo energije. 
        /// Če ni izbrana nobena naprava, prikaže sporočilo, da je potrebno najprej dodati napravo.
        /// </summary>
        private void btnVklopi_Click(object sender, EventArgs e)
        {
            if (trenutnaNaprava != null)
            {
                PorabaServis servis = new PorabaServis();
                trenutnaNaprava.Vklopi();
                MessageBox.Show($"{trenutnaNaprava.Ime} je vklopljena!");
                Poraba.Text = trenutnaNaprava.PorabaEnergije().ToString();
                celotnaPoraba.Text = servis.SkupnaPoraba(seznamNaprav.VrniVse()).ToString();
            }
            else
            {
                MessageBox.Show("Najprej dodaj napravo!");
            }
        }

        /// <summary>
        /// Sproži dogodek za izklop naprave ter jo odstrani s tem da jo deklarira kot null. 
        /// Prikaže sporočilo, da je naprava odstranjena.
        /// </summary>
        private void btnIzbris_Click(object sender, EventArgs e)
        {
            trenutnaNaprava.Odstrani();
            trenutnaNaprava = null;
            MessageBox.Show("Naprava odstranjena!");
        }

        /// <summary>
        /// Pokliče metodo UpdateTemperatureTextBoxVisibility, ki posodobi vidljivost textBox1 glede na to, ali sta klima ali termostat označena.
        /// </summary>
        private void Klima_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTemperatureTextBoxVisibility();
        }

        /// <summary>
        /// Posodobi vidljivost textBox1 glede na to, ali sta klima ali termostat označena.
        /// </summary>
        private void UpdateTemperatureTextBoxVisibility()
        {
            if (Klima.Checked || Termostat.Checked)
                textBox1.Visible = true;
            else
                textBox1.Visible = false;
        }

        /// <summary>
        /// Pokliče metodo UpdateTemperatureTextBoxVisibility, ki posodobi vidljivost textBox1 glede na to, ali sta klima ali termostat označena.
        /// </summary>
        private void Termostat_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTemperatureTextBoxVisibility();
        }
        /// <summary>
        /// Pokliče metodo VrniSteviloNaprav iz razreda Naprave, ki vrne trenutno število naprav v sistemu, in posodobi prikaz v textBoxu Stevilo.
        /// </summary>
        /// <returns></returns>
        public int UpdateStNaprav()
        {
            return Naprave.VrniSteviloNaprav();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Primerja dve napravi glede na izbran operator.
        /// Vrne sporočilo o rezultatu primerjave, kot so "Enaki sta", "Nista enaki", "Naprava1 porabi manj/več kot Naprava2" ali skupna poraba obeh naprav.
        /// </summary>
        private void primerjaj_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            Naprave n1 = NajdiNapravoPoImenu(textBox2.Text);
            Naprave n2 = NajdiNapravoPoImenu(textBox3.Text);

            if (n1 == null || n2 == null)
            {
                textBox4.Text = "Naprava ne obstaja!";
                return;
            }
            if (radioButton1.Checked)
            {
                textBox4.Text = (n1 == n2) ? "Enaki sta" : "Nista enaki";
            }
            else if (radioButton2.Checked)
            {
                textBox4.Text = (n1 != n2) ? "Nista enaki" : "Enaki sta";
            }
            else if (radioButton3.Checked)
            {
                textBox4.Text = (n1 < n2)
                    ? $"{n1.Ime} porabi manj kot {n2.Ime}"
                    : $"{n1.Ime} porabi več ali enako kot {n2.Ime}";
            }
            else if (radioButton4.Checked)
            {
                textBox4.Text = (n1 > n2)
                    ? $"{n1.Ime} porabi več kot {n2.Ime}"
                    : $"{n1.Ime} porabi manj kot {n2.Ime}";
            }
            else if (radioButton5.Checked)
            {
                double skupnaPoraba = n1 + n2;

                textBox4.Text =
                    $"Skupna poraba naprav {n1.Ime} + {n2.Ime} = {skupnaPoraba} W";
            }
            else
            {
                textBox4.Text = "Izberi operator!";
            }
        }

        /// <summary>
        /// Najde napravo v seznamu glede na njeno ime. 
        /// Če naprava z danim imenom obstaja, jo vrne, sicer vrne null.
        /// </summary>
        private Naprave NajdiNapravoPoImenu(string ime)
        {
            foreach (Naprave n in seznamNaprav.VrniVse())
            {
                if (n.Ime == ime)
                    return n;
            }
            return null;
        }

        private void prEnergije_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Izvede nočni scenarij in izklopi vse naprave.
        /// Izbriše ves tekst iz TextBox-ov.
        /// </summary>
        private void nightMode_Click(object sender, EventArgs e)
        {
            Scenarij ns = new NocniScenarij();
            ns.Izvedi(seznamNaprav.VrniVse());
            textBox1.Clear();
            Stevilo.Clear();
            Poraba.Clear();
            celotnaPoraba.Clear();
        }

        /// <summary>
        /// Vklopi vse naprave v seznamu s pomočjo razreda Upravljalnik, ki ima metodo IzvediNaVseh, ki sprejme seznam naprav in akcijo (v tem primeru klic metode Vklopi za vsako napravo).
        /// </summary>
        private void VklopiVseNaprave(object sender, EventArgs e)
        {
            Upravljalnik upravljalnik = new Upravljalnik();

            upravljalnik.IzvediNaVseh(seznamNaprav.VrniVse(), n => n.Vklopi());
        }

        /// <summary>
        /// Izklopi vse naprave v seznamu s pomočjo razreda Upravljalnik, ki ima metodo IzvediNaVseh, ki sprejme seznam naprav in akcijo (v tem primeru klic metode Izklopi za vsako napravo).
        /// </summary>
        private void IzklopiVseNaprave(object sender, EventArgs e)
        {
            Upravljalnik upravljalnik1 = new Upravljalnik();

            upravljalnik1.IzvediNaVseh(seznamNaprav.VrniVse(), n => n.Izklopi());
        }
    }
}
