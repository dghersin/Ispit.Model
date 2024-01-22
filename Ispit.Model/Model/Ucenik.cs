namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public void IspisUcenika(List<Ucenik> ucenici)
        {
            foreach (Ucenik ucenik in ucenici)
            {
                IspisUcenika(ucenik);
            }
        }

        public void IspisUcenika(Ucenik ucenik)
        {
            Console.WriteLine("Ime ucenika: " + ucenik.Ime);
            Console.WriteLine("Prezime ucenika: " + ucenik.Prezime);
            Console.WriteLine("Datum rodjenja ucenika: " + ucenik.DatumRodjenja + " te ima " + Starost(ucenik.DatumRodjenja) + " godina/e.");
            Console.Write($"Prosjek ocjena ucenika: " + ucenik.Prosjek + " te mu je ocjena ");
            IspisProsjeka(ucenik.Prosjek);
        }

        public List<Ucenik> UnesiUcenika(int kolicina)
        {
            List<Ucenik> ucenici = new List<Ucenik>();
            for (int brojcanik = 0; brojcanik < kolicina; brojcanik++)
            {
                ucenici.Add(UnesiPodatkeUcenika());
            }
            return ucenici;
        }

        public int Starost(DateTime DatumRodjenja)
        {
            DateTime danas = DateTime.Now;
            int godine = danas.Year - DatumRodjenja.Year;
            if (danas.Month < DatumRodjenja.Month || (danas.Month == DatumRodjenja.Month && danas.Day < DatumRodjenja.Day))
            {
                godine--;
            }

            return godine;
        }

        public void IspisProsjeka(double Prosjek)
        {
            if (Prosjek >= 1 && Prosjek < 1.49)
            {
                Console.WriteLine("Nedovoljan");
            }
            else if (Prosjek >= 1.5 && Prosjek < 2.5)
            {
                Console.WriteLine("Dovoljan");
            }
            else if (Prosjek >= 2.5 && Prosjek < 3.5)
            {
                Console.WriteLine("Dobar");
            }
            else if (Prosjek >= 3.5 && Prosjek < 4.5)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else if (Prosjek >= 4.5 && Prosjek <= 5)
            {
                Console.WriteLine("Odličan");
            }
            else
            {
                Console.WriteLine("Nepoznata ocjena");
            }
        }

        public Ucenik UnesiPodatkeUcenika()
        {
            Ucenik ucenik = new Ucenik();

            Console.WriteLine("Unesi ime ucenika: ");
            ucenik.Ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime ucenika: ");
            ucenik.Prezime = Console.ReadLine();
            Console.WriteLine("Unesi datum rodjenja ucenika (DD/MM/YYYY) : ");
            ucenik.DatumRodjenja = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Unesi prosjek ocjena ucenika (xx,xx) : ");
            ucenik.Prosjek = double.Parse(Console.ReadLine());
            return ucenik;
          
        }

    }
}
