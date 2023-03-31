using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludzie
{
    class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> oceny = new List<Ocena>();

        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_) :
            base(imie_, nazwisko_, dataUrodzenia_)
        {
            rok = rok_;
            grupa = grupa_;
            nrIndeksu = nrIndeksu_;
        }

        public int Rok
        {
            get
            {
                return rok;
            }
        }

        public int Grupa
        {
            get
            {
                return grupa;
            }
        }

        public int NrIndeksu
        {
            get
            {
                return nrIndeksu;
            }
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine(rok + ", " + grupa + ", " + NrIndeksu);
            WypiszOceny();
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            Ocena oc = new(nazwaPrzedmiotu, data, wartosc);
            oceny.Add(oc);
        }

        public void WypiszOceny()
        {
            foreach (Ocena oc in oceny)
            {
                Console.WriteLine(oc.Data + ", " + oc.NazwaPrzedmiotu + ", " + oc.Wartosc);
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            Console.WriteLine("Oceny z przedmiotu " + nazwaPrzedmiotu + ";");
            foreach (Ocena oc in oceny)
            {
                if (nazwaPrzedmiotu == oc.NazwaPrzedmiotu)
                    Console.WriteLine(oc.Data + ", " + oc.Wartosc);
            }
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    ++i;
                }
            }
        }

        public void UsunOceny()
        {
            oceny.Clear();
        }

        public void UsunOceny(string nazwaPrzedmiotu)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
