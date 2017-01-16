using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodróży
{
    class Express : SrodekLokomocji
    {
        public Express(int miejsca) 
        {
            iloscMiejsc = miejsca;
            ObliczCene();

        }
    public override string ToString()
    {
        return "Express: ilośc miejsc: " + iloscMiejsc + ", cena biletu: " + cenaBiletu;
    
    }

    }
}
