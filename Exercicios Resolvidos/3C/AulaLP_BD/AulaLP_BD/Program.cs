using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaLP_BD
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            List<Carro> c = new List<Carro>();
            while (true)
            {
                Console.WriteLine("1 - Para adicionar um carro");
                Console.WriteLine("2 - Para remover um carro");
                Console.WriteLine("3 - Para sair");
                x = int.Parse(Console.ReadLine());
                Console.Clear();
                if (x == 1)
                {
                    Carro car = new Carro();
                    Console.Write("Digite a marca : ");
                    car.Marca = Console.ReadLine();
                    Console.Write("Digite o modelo : ");
                    car.Modelo = Console.ReadLine();
                    Console.Write("Digite a cor : ");
                    car.Cor = Console.ReadLine();
                    Console.Write("Digite a placa : ");
                    car.Placa = Console.ReadLine();
                    Console.Write("Digite a potencia : ");
                    car.Potencia = int.Parse(Console.ReadLine());
                    c.Add(car);
                    Console.Clear();
                }
                else if (x == 2)
                {
                    
                }
                else if (x == 3)
                {
                    break;
                }

            }
            SqlConnection connect = new SqlConnection("Data Source=localhost;Initial Catalog=BDLP;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            connect.Open();
            for (int i = 0; i < c.Count; i++)
            {
                string r = string.Format("INSERT INTO Carro(Marca , Modelo , Cor , Placa, Potencia) VALUES ('{0}','{1}','{2}','{3}','{4}');", c[i].Marca, c[i].Modelo, c[i].Cor, c[i].Placa, c[i].Potencia);
                cmd.CommandText = r;
                cmd.ExecuteNonQuery();
            }
            connect.Close();
            Console.WriteLine("ok");

        }
    }
}
