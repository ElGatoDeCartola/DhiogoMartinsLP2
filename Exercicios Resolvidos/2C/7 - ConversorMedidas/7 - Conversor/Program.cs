using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite Seu Valor");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("1 - Quilo para Grama");
                Console.WriteLine("2 - Quilo para Tonelada");
                Console.WriteLine("3 - Quilo para Libra");
                Console.WriteLine("4 - Celcius para Farenheit");
                Console.WriteLine("5 - Celcius para Kelvin");
                Console.WriteLine("6 - Metro para Kilometro");
                Console.WriteLine("7 - Sair");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine(Conversor.KgG(a));
                }
                if (x == 2)
                {
                    Console.WriteLine(Conversor.KgT(a));
                }
                if (x == 3)
                {
                    Console.WriteLine(Conversor.KgLb(a));
                }
                if (x == 4)
                {
                    Console.WriteLine(Conversor.CF(a));
                }
                if (x == 5)
                {
                    Console.WriteLine(Conversor.CK(a));
                }
                if (x == 6)
                {
                    Console.WriteLine(Conversor.MetroKm(a));
                }
                if (x == 7)
                {
                    break;
                }
            }
        }
    }
}
