using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludzie
{
    class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli;

        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_) :
            base(imie_, nazwisko_, dataUrodzenia_)
        {
            pozycja = pozycja_;
            klub = klub_;
        }

        public string Pozycja
        {
            get
            {
                return pozycja;
            }
        }

        public string Klub
        {
            get
            {
                return klub;
            }
        }

        public int LiczbaGoli
        {
            get
            {
                return liczbaGoli;
            }
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine(pozycja + ", " + klub + ", " + liczbaGoli);
        }

        public virtual void StrzelGola()
        {
            liczbaGoli = liczbaGoli + 1;
        }
    }
}
