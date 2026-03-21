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

        public void Vklopi()
        {
            Vklopljena = true;
            SporociSpremembo($"{Ime} je vklopjena!");
        }
        public void Izklopi()
        {
            Vklopljena = false;
            SporociSpremembo($"{Ime} je izklopljena!");
        }
        public virtual double PorabaEnergije()
        {
            return 0;
        }
        public static int VrniSteviloNaprav()
        {
            return StevecNaprav;
        }

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

        public event EventHandler<string> OnStatusChanged;

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

        public override double PorabaEnergije()
        {
            if (!Vklopljena) return 0;

            if (vrsta_zarnice == "LED") return moc_svetlosti * LED;
            else if (vrsta_zarnice == "Klasika") return moc_svetlosti * klasik;
            else if (vrsta_zarnice == "Halogenska") return moc_svetlosti * halogenska;

            else return 0;
        }

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

        public event EventHandler AlarmTriggered;

        public Alarm(string ime, int g, string m) : base(ime)
        {
            glasnost = g;
            melodija = m;
        }

        public void UgasniAlarm()
        {
            if (vklopljen)
            {
                vklopljen = false;
                Console.WriteLine("Alarm se je izklopil.");
            }
        }

        public override double PorabaEnergije()
        {
            if (!Vklopljena)
                return 0;
            else
                return 10;
        }

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

        public void SpremeniTemp(int t)
        {
            temperatura += t;
            TemperaturaChanged?.Invoke(temperatura);
        }

        public int IzpisTemparature()
        {
            return temperatura;
        }

        public override double PorabaEnergije()
        {
            if (!Vklopljena) return 0;
            else return 25000;
        }

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
        public string Spust_Rolete()
        {
            return "Roleta se je spustila!";
        }

        public string Dvig_Rolete()
        {
            return "Roleta se je dvignila!";
        }

        public override double PorabaEnergije()
        {
            if (!Vklopljena)
                return 0;
            else
                return 150;
        }

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

        public void SpremeniTempKlime(int i)
        {
            temp = i;
        }

        public int IzpisTemparature()
        {
            return temp;
        }

        public override double PorabaEnergije()
        {
            if (!Vklopljena)return 0;

            if (velikost_klime == "Majhna") return 3000;
            else if (velikost_klime == "Srednja") return 3500;
            else if (velikost_klime == "Velika") return 5000;
            else return 0;
        }

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

        public void Dodaj(Naprave n)
        {
            naprave.Add(n);
        }

        public Naprave this[int index]
        {
            get { return naprave[index]; }
        }

        public List<Naprave> VrniVse()
        {
            return naprave;
        }

        public int Count => naprave.Count;
    }

    public class NocniScenarij : Scenarij
    {
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
        public void IzvediNaVseh(List<Naprave> naprave, AkcijaNaprave akcija)
        {
            foreach (var n in naprave)
            {
                akcija(n);
            }
        }
    }
}
