using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Empregado : Funcionario
    {
        public string Data_Entrada { get; set; }
        public Gerente Gerente { get; set; }
    }
}