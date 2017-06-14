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