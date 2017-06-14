using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentando
{
    class Program
    {
        static void Main(string[] args)
        {
            int q;      

            Console.WriteLine("Qual o número de carros no galpão?");
            q = int.Parse(Console.ReadLine());

            Carro[] carrocho = new Carro[q];
        
            for (int i = 0; i < q; i++)
            {
                carrocho[i] = new Carro();

                Console.WriteLine("\nInforme o modelo do carro");
                carrocho[i].mol = Console.ReadLine();

                Console.WriteLine("\nInforme o número de km rodados");
                carrocho[i].km = double.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme a potência do motor");
                carrocho[i].pot = double.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o ano de fabricação");
                carrocho[i].anocar = int.Parse(Console.ReadLine());        
            }

            for (int i = 0; i < q; i++)
            {
                Console.WriteLine(carrocho[i].Classificar());
               
            }

        }
    }
}

