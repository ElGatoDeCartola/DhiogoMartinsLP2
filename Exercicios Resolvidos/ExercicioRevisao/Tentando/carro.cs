using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentando
{
    class Carro
    {
        public string mol;
        public double km;
        public double pot, novo;
        public int anocar;

        public string Classificar()
        {
            string ida, pote;

            if (km <= 5000)
            {
                ida = "Novo";
            }

            else if (km >= 3000)
            {
                ida = "Seminovo";
            }

            else
            {
                ida = "Velho";
            }

            //aqui começa o if da potencia

            if (pot >= 200)
            {
                pote = "Potente";
            }

            else if (pot < 200 && pot >= 120)
            {
                pote = "Forte";
            }

            else
            {
                pote = "Popular";
            }

            return String.Format("{0} - {1} - {2}", mol, ida, pote);
        }

        public double taxa()
        {
            return km / (DateTime.Now.Year - anocar);
        }

        public void attkm(double novo)
        {
            km = novo;
        }
       
    }
}
