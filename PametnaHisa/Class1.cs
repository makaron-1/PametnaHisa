using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace RazrediNaprav
{
    public delegate void AkcijaNaprave(Naprave n);

    interface ITemperaturnaNaprava
    {
        int IzpisTemparature();
    }
  
    interface IVarnost
    {
        string geslo { get; set; }
        bool VnesiGeslo(string g);
    }

    public abstract class Scenarij
    {
        public abstract void Izvedi(List<Naprave> naprave);
    }
    public class Naprave
    {
        private bool vklopljena;
        public static int StevecNaprav;

        public string Ime { get; set; }

        public bool Vklopljena
        {
            get { return vklopljena; }
            protected set { vklopljena = value; }
        }

        protected Naprave(string ime)
        {
            Ime = ime;
            StevecNaprav++;
            vklopljena = false;
        }

        ~Naprave()
        {
            Console.WriteLine($"Naprava {Ime} odstranjena iz pomnilnika.");
        }

        /// <summary>
        /// Vklopi napravo in sproži dogodek o spremembi statusa.
        /// </summary>
        public void Vklopi()
        {
            Vklopljena = true;
            SporociSpremembo($"{Ime} je vklopjena!");
        }

        /// <summary>
        /// Izklopi napravo in sproži dogodek o spremembi statusa.
        /// </summary>
        public void Izklopi()
        {
            Vklopljena = false;
            SporociSpremembo($"{Ime} je izklopljena!");
        }

        /// <summary>
        /// Vrne porabo energije naprave.
        /// </summary>
        public virtual double PorabaEnergije()
        {
            return 0;
        }

        /// <summary>
        /// Vrne skupno število vseh ustvarjenih naprav.
        /// </summary>
        public static int VrniSteviloNaprav()
        {
            return StevecNaprav;
        }

        /// <summary>
        /// Odstrani napravo tako, da jo izklopi in zmanjša števec naprav.
        /// </summary>
        public void Odstrani()
        {
            Vklopljena = false;
        }

        public static double operator +(Naprave n1, Naprave n2)
        {
            return n1.PorabaEnergije() + n2.PorabaEnergije();
        }

        public static bool operator ==(Naprave n1, Naprave n2)
        {
            if (ReferenceEquals(n1, n2)) return true;
            if (n1 is null || n2 is null) return false;

            return n1.Ime == n2.Ime;
        }

        public static bool operator !=(Naprave n1, Naprave n2)
        {
            return !(n1 == n2);
        }

        public override bool Equals(object obj)
        {
            Naprave other = obj as Naprave;
            if (other == null) return false;

            return this.Ime == other.Ime;
        }

        public override int GetHashCode()
        {
            return Ime.GetHashCode();
        }

        public static bool operator >(Naprave n1, Naprave n2)
        {
            return n1.PorabaEnergije() > n2.PorabaEnergije();
        }

        public static bool operator <(Naprave n1, Naprave n2)
        {
            return n1.PorabaEnergije() < n2.PorabaEnergije();
        }

        public override string ToString()
        {
            return $"{Ime} , Vklopljena: {Vklopljena})";
        }

        /// <summary>
        /// Dogodek, ki se sproži ob spremembi statusa naprave.
        /// </summary>
        public event EventHandler<string> OnStatusChanged;

        /// <summary>
        /// Sproži dogodek o spremembi statusa. Vrne sporočilo glede na statusu naprave (npr. "Luč je vklopljena!").
        /// </summary>
        protected void SporociSpremembo(string msg)
        {
            OnStatusChanged?.Invoke(this, msg);
        }
    }
    public class Luc : Naprave, IVarnost
    {
        public string vrsta_zarnice;
        public int moc_svetlosti;
        public bool dim_mode;
        private string _geslo = "luc";

        public string geslo
        {
            get { return _geslo; }
            set { _geslo = value; }
        }
        const double LED = 0.01;
        const double klasik = 0.06;
        const double halogenska = 0.03;

        public Luc(string ime, string vz, int moc, string dim) : base(ime)
        {
            vrsta_zarnice = vz;
            moc_svetlosti = moc;
            if(dim == "DA")
            {
                dim_mode = true;
            }
            else
            {
                dim_mode = false;
            }
        }

        /// <summary>
        /// Izračuna porabo energije glede na vrsto žarnice. Vrne neko porabo, če je luč vklopljena, sicer vrne 0.
        /// </summary>
        public override double PorabaEnergije()
        {
            if (!Vklopljena) return 0;

            if (vrsta_zarnice == "LED") return moc_svetlosti * LED;
            else if (vrsta_zarnice == "Klasika") return moc_svetlosti * klasik;
            else if (vrsta_zarnice == "Halogenska") return moc_svetlosti * halogenska;

            else return 0;
        }

        /// <summary>
        /// Preveri pravilnost vnesenega gesla za luč. Vrne true, če je geslo pravilno, sicer vrne false.
        /// </summary>
        public bool VnesiGeslo(string g)
        {
            if(g == geslo)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
    }
    public class Alarm : Naprave, IVarnost
    {
        public int glasnost;
        public string melodija;
        private string _geslo = "alarm";
        public string geslo
        {
            get { return _geslo; }
            set { _geslo = value; }
        }

        private static Random rnd = new Random();
        private bool vklopljen = rnd.Next(0, 2) == 1;

        public bool Aktiviran
        {
            get { return vklopljen; }
            set { vklopljen = value; }
        }

        /// <summary>
        /// Dogodek, ki se sproži ob aktivaciji alarma.
        /// </summary>
        public event EventHandler AlarmTriggered;

        public Alarm(string ime, int g, string m) : base(ime)
        {
            glasnost = g;
            melodija = m;
        }

        /// <summary>
        /// Izklopi alarm, če je aktiven. Vrne sporočilo o izklopu alarma. Če alarm ni aktiven, ne naredi nič.
        /// </summary>
        public void UgasniAlarm()
        {
            if (vklopljen)
            {
                vklopljen = false;
                Console.WriteLine("Alarm se je izklopil.");
            }
        }

        /// <summary>
        /// Izračuna porabo energije alarma. Vrne neko porabo, če je alarm vklopljen, sicer vrne 0.
        /// </summary>
        public override double PorabaEnergije()
        {
            if (!Vklopljena)
                return 0;
            else
                return 10;
        }

        /// <summary>
        /// Preveri pravilnost gesla za alarm. Vrne true, če je geslo pravilno, sicer vrne false.
        /// </summary>
        public bool VnesiGeslo(string g)
        {
            if (g == geslo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sproži alarm in obvesti vse naročnike dogodka.
        /// </summary>
        public void SproziAlarm()
        {
            Aktiviran = true;
            AlarmTriggered?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Termostat : Naprave, ITemperaturnaNaprava , IVarnost
    {
        public int temperatura;
        private string  temp_mode;
        private string _geslo = "termostat";
        public string geslo
        {
            get { return _geslo; }
            set { _geslo = value; }
        }

        /// <summary>
        /// Dogodek, ki se sproži ob spremembi temperature.
        /// </summary>
        public event Action<int> TemperaturaChanged;
        public string Temp_Mode
        {
            get { return temp_mode; }
            set
            {
                temp_mode = value;

                if (value == "hot")
                    temperatura = 30;
                else if (value == "cold")
                    temperatura = -10;
                else Console.WriteLine("Tempraratura je enaka kot vpisana!");
            }
        }

        public Termostat(string ime, int t, string m) : base(ime)
        {
            temperatura = t;
            Temp_Mode = m;
        }

        /// <summary>
        /// Spremeni temperaturo in sproži dogodek. Vrne novo temperaturo. Če je naprava izklopljena, ne spremeni temperature in ne sproži dogodka.
        /// </summary>
        public void SpremeniTemp(int t)
        {
            temperatura += t;
            TemperaturaChanged?.Invoke(temperatura);
        }

        /// <summary>
        /// Vrne trenutno temperaturo. Vrne temperaturo v stopinjah Celzija. Če je naprava izklopljena, vrne 0.
        /// </summary>
        public int IzpisTemparature()
        {
            return temperatura;
        }

        /// <summary>
        /// Izračuna porabo energije glede na temperaturo. Vrne neko porabo, če je termostat vklopljen, sicer vrne 0. Poraba se lahko poveča z višjo temperaturo.
        /// </summary>
        public override double PorabaEnergije()
        {
            if (!Vklopljena) return 0;
            else return 25000;
        }

        /// <summary>
        /// Preveri pravilnost gesla za termostat. Vrne true, če je geslo pravilno, sicer vrne false.
        /// </summary>
        public bool VnesiGeslo(string g)
        {
            if (g == geslo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Roleta : Naprave, IVarnost
    {
        public string vrsta_rolete;
        private string _geslo = "roleta";
        public string geslo
        {
            get { return _geslo; }
            set { _geslo = value; }
        }

        public Roleta(string ime, string v) : base(ime)
        {
            vrsta_rolete = v;
        }

        /// <summary>
        /// Spusti roleto. Vrne sporočilo o spuščanju rolete. Če je naprava izklopljena, ne spusti rolete in ne vrne sporočila.
        /// </summary>
        public string Spust_Rolete()
        {
            return "Roleta se je spustila!";
        }

        /// <summary>
        /// Dvigne roleto. Vrne sporočilo o dviganju rolete. Če je naprava izklopljena, ne dvigne rolete in ne vrne sporočila.
        /// </summary>
        public string Dvig_Rolete()
        {
            return "Roleta se je dvignila!";
        }

        /// <summary>
        /// Izračuna porabo energije rolete. Vrne neko porabo, če je roleta vklopljena, sicer vrne 0. Poraba se lahko poveča z večjo velikostjo rolete.
        /// </summary>
        public override double PorabaEnergije()
        {
            if (!Vklopljena)
                return 0;
            else
                return 150;
        }

        /// <summary>
        /// Preveri pravilnost gesla za roleto. Vrne true, če je geslo pravilno, sicer vrne false.
        /// </summary>
        public bool VnesiGeslo(string g)
        {
            if (g == geslo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Klima : Naprave, ITemperaturnaNaprava, IVarnost
    {
        public int temp;
        public string velikost_klime;
        private bool poletno_hlajenje;
        private string _geslo = "klima";
        public string geslo
        {
            get { return _geslo; }
            set { _geslo = value; }
        }

        public bool PoletnoHlajenje
        {
            get { return poletno_hlajenje; }
            set { poletno_hlajenje = value; }
        }

        public Klima(string ime, int t, string v , string OnOff ) : base(ime)
        {
            temp = t;
            velikost_klime = v;
            if (OnOff == "DA")
            {
                poletno_hlajenje = true;
            }
            else
            {
                poletno_hlajenje = false;
            }
        }

        /// <summary>
        /// Spremeni temperaturo klime. Vrne novo temperaturo.
        /// </summary>
        public void SpremeniTempKlime(int i)
        {
            temp = i;
        }

        /// <summary>
        /// Vrne trenutno temperaturo klime.
        /// </summary>
        public int IzpisTemparature()
        {
            return temp;
        }

        /// <summary>
        /// Izračuna porabo energije glede na velikost klime. Vrne neko porabo, če je klima vklopljena, sicer vrne 0. Poraba se lahko poveča z večjo velikostjo klime.
        /// </summary>
        public override double PorabaEnergije()
        {
            if (!Vklopljena)return 0;

            if (velikost_klime == "Majhna") return 3000;
            else if (velikost_klime == "Srednja") return 3500;
            else if (velikost_klime == "Velika") return 5000;
            else return 0;
        }

        /// <summary>
        /// Preveri pravilnost gesla za klimo. Vrne true, če je geslo pravilno, sicer vrne false.
        /// </summary>
        public bool VnesiGeslo(string g)
        {
            if (g == geslo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class SeznamNaprav
    {
        private List<Naprave> naprave = new List<Naprave>();

        /// <summary>
        /// Doda napravo v seznam. Sprejme objekt tipa Naprave in ga doda v seznam naprav.
        /// </summary>
        public void Dodaj(Naprave n)
        {
            naprave.Add(n);
        }

        public Naprave this[int index]
        {
            get { return naprave[index]; }
        }

        /// <summary>
        /// Vrne seznam vseh naprav. Vrne List<Naprave> z vsemi napravami v seznamu.
        /// </summary>
        public List<Naprave> VrniVse()
        {
            return naprave;
        }

        public int Count => naprave.Count;
    }

    public class NocniScenarij : Scenarij
    {
        /// <summary>
        /// Izvede nočni scenarij tako, da izklopi vse naprave v seznamu. Sprejme List<Naprave> in za vsako napravo v seznamu pokliče metodo Izklopi(). Po izvedbi scenarija izpiše sporočilo "Nočni način aktiviran.".
        /// </summary>
        public override void Izvedi(List<Naprave> naprave)
        {
            foreach (var n in naprave)
            {
                n.Izklopi();
            }
            Console.WriteLine("Nočni način aktiviran.");
        }
    }

    public class PorabaServis
    {
        /// <summary>
        /// Sproti računa skupno porabo energije vseh naprav ter jo vrne. 
        /// Sprejme List<Naprave> in za vsako napravo v seznamu pokliče metodo PorabaEnergije() ter sešteje te porabe. 
        /// Na koncu vrne skupno porabo energije vseh naprav.
        /// </summary>
        public double SkupnaPoraba(List<Naprave> naprave)
        {
            double vsota = 0;

            foreach (var n in naprave)
            {
                vsota += n.PorabaEnergije();//polimorfizem
            }

            return vsota;
        }
    }

    public class Upravljalnik
    {
        /// <summary>
        /// Izvede dano akcijo na vseh napravah v seznamu. 
        /// Sprejme List<Naprave> in delegata AkcijaNaprave, ter za vsako napravo v seznamu pokliče akcijo, ki jo določa delegat. 
        /// Na ta način lahko upravljalnik izvede poljubno akcijo (npr. vklopi, izklopi, spremeni temperaturo) na vseh napravah v seznamu.
        /// </summary>
        public void IzvediNaVseh(List<Naprave> naprave, AkcijaNaprave akcija)
        {
            foreach (var n in naprave)
            {
                akcija(n);
            }
        }
    }
}
