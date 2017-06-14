using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corrida
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Qual o número de competidores?");
            n = int.Parse(Console.ReadLine());

            double t1,t2,t3;
            double menorTempo = double.MaxValue;
            string vencedor = "";

            Competidor[] competidores = new Competidor[n];

            for(int i = 0; i < n; i++)
            {
                competidores[i] = new Competidor();

                Console.WriteLine("\nInsira o nome do competidor {0}", i+1);
                competidores[i].name = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nInsira o 1º tempo do competidor {0}", competidores[i].name);
                competidores[i].t1 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nInsira o 2º tempo do competidor {0}", competidores[i].name);
                competidores[i].t2 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nInsira o 3º tempo do competidor {0}", competidores[i].name);
                competidores[i].t3 = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (competidores[i].calte() < menorTempo)
                {
                    menorTempo = competidores[i].calte();

                    vencedor = competidores[i].name;
                }
            }

            Console.WriteLine("\n{0}", vencedor);

        }
    }
}
