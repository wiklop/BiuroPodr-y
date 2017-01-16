using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodróży
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji(){}

            public virtual void ObliczCene()
        {
            this.cenaBiletu=iloscMiejsc*5.23;
        }
        public double ZwrocCene() {

            return this.cenaBiletu;
        }
    }
}
