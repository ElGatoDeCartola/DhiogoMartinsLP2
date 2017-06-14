using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Competidor
    {
        public string name;
        public double t1, t2, t3;
        
        public double calte()
        {
            double[] tempos = new double[3]{t1,t2,t3};

            Array.Sort(tempos);
            double conta = tempos[0] + tempos[1];

            return conta;

        }
    }
}
