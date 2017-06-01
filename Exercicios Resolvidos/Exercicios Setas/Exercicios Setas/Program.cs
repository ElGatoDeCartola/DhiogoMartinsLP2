using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 600, L = 800;

            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            Objeto2D obj = new Objeto2D();

            obj.X = x;
            obj.Y = y;

            Console.Write("Digite comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            if (comando == ConsoleKey.RightArrow)
            {
                obj.AndarParaADireita();
                Console.WriteLine(obj.Coordenadas());
            }
            if (comando == ConsoleKey.LeftArrow)
            {
                obj.AndarParaAEsquerda();
                Console.WriteLine(obj.Coordenadas());
            }
            if (comando == ConsoleKey.DownArrow)
            {
                obj.AndarParaBaixo();
                Console.WriteLine(obj.Coordenadas());
            }
            if (comando == ConsoleKey.UpArrow)
            {
                obj.AndarParaCima();
                Console.WriteLine(obj.Coordenadas());
            }
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Objeto2D
    {
        public int X;
        public int Y;
        public void AndarParaADireita()
        {
            X++;
        }
        public void AndarParaAEsquerda()
        {
            X--;
        }
        public void AndarParaCima()
        {
            Y++;
        }
        public void AndarParaBaixo()
        {
            Y--;
        }
        public string Coordenadas()
        {
            return String.Format("({0} {1})" ,Y , X );
        }
    }
}
/*