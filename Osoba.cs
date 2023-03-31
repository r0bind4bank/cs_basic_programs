using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludzie
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }

        public string Imie
        {
            get
            {
                return imie;
            }
        }

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
        }

        public string DataUrodzenia
        {
            get
            {
                return dataUrodzenia;
            }
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine(imie + ", " + nazwisko + ", " + dataUrodzenia);
        }
    }
}
