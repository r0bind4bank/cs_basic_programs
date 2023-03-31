using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludzie
{
    class Ocena
    {
        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public Ocena(string nazwaPrzedmiotu, string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.data = data;
            this.wartosc = wartosc;
        }

        public string NazwaPrzedmiotu
        {
            get
            {
                return nazwaPrzedmiotu;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }
        }

        public double Wartosc
        {
            get
            {
                return wartosc;
            }
        }

        public void WypiszInfo()
        {         
            Console.WriteLine(data + ", " + nazwaPrzedmiotu + ", " + wartosc);
        }
    }
}
