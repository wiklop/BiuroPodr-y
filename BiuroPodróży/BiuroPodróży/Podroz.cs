using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodróży
{
    class Podroz:IZarzadzaj,IData
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy;
        private double koszt = 200;


        public Podroz()
        {
            planPodrozy = new List<SrodekLokomocji>();
        }

        public void DodajExpress(int iloscMiejsc)
        {
            planPodrozy.Add(new Express(iloscMiejsc));
            int pom = planPodrozy.Count;
            koszt += planPodrozy[pom - 1].ZwrocCene();
        }
        public void DodajSamolot(int iloscMiejsc,int odleglosc)
        {
            planPodrozy.Add(new Samolot(iloscMiejsc,odleglosc));
            int pom = planPodrozy.Count;
            koszt += planPodrozy[pom - 1].ZwrocCene();
        }
        public void UsunOstatni()
        {
            if (planPodrozy.Count > 0) { 
                planPodrozy.Remove(planPodrozy.Last());
                int pom = planPodrozy.Count;
                koszt -= planPodrozy[pom - 1].ZwrocCene();
            }
        
        }

        public void Wyczysc()
        {
            planPodrozy.Clear();
            
        }

        public void UstawDate(DateTime data)
        {
            dataPodrozy = data;
        }

        public bool SprawdzDate() 
        {
            if (dataPodrozy > DateTime.Now) return true;
            else return false;
        }

        public override string ToString()
        {
            string informacja = "Plan podróży ";
            foreach (var element in planPodrozy)
            {
                informacja += Environment.NewLine + element.ToString();          
            }
            informacja += Environment.NewLine + "Koszt: " + koszt;

                return informacja;
            
        }


    }
}
