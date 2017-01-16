using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodróży
{
    class Samolot:SrodekLokomocji
    {
        private int odleglosc;
        public override void ObliczCene()
        {
            if (this.odleglosc > 200)
            {
                cenaBiletu = odleglosc * 6.41;
            }
            else
            {
                cenaBiletu = 33;
            }        
        }
        public Samolot(int miejsca, int dystans)
        {
            this.iloscMiejsc = miejsca;
            this.odleglosc = dystans;
            ObliczCene();
        }
        public override string ToString()
        {
            return "Samolot: ilośc miejsc: " + iloscMiejsc + ", cena biletu: " +cenaBiletu ;

        }
    }
}
