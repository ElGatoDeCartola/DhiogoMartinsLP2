using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando, n;
            int x, j;
            Carro carro = new Carro();
            Funcionario funcionario = new Funcionario();
            x = 1;
            SqlCommand cmd = new SqlCommand();
            SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=LPBD;Integrated Security=SSPI");
            cmd.Connection = conec;

            while (x != 0)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1 - Cadastrar carro");
                Console.WriteLine("2 - Deletar carro");
                Console.WriteLine("3 - Exibir carros");
                Console.WriteLine("4 - Alterar carro");
                Console.WriteLine("5 - Cadastrar funcionario");
                Console.WriteLine("6 - Deletar funcionario");
                Console.WriteLine("7 - Exibir funcionarios");
                Console.WriteLine("8 - Alterar funcionario");
                Console.WriteLine("9 - Calcular total de venda de carros");
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("-------------------------------------------------------");
                Console.Write("Resposta: ");
                x = int.Parse(Console.ReadLine());

                if (x == 1)
                {

                    Console.WriteLine("   Insira os dados do Carro: ");

                    Console.Write("   Marca: ");
                    carro.Marca = Console.ReadLine();

                    Console.Write("   Modelo: ");
                    carro.Modelo = Console.ReadLine();

                    Console.Write("   Cor: ");
                    carro.Cor = Console.ReadLine();

                    Console.Write("   Preço: ");
                    carro.Preço = int.Parse(Console.ReadLine());

                    Console.Write("   Potencia: ");
                    carro.Potencia = int.Parse(Console.ReadLine());

                    Console.Write("   Numero de portas: ");
                    carro.Porta = int.Parse(Console.ReadLine());

                    Console.Write("   Cambio: ");
                    carro.Cambio = Console.ReadLine();

                    Console.Write("   Traçao: ");
                    carro.Traçao = Console.ReadLine();

                    Console.Write("   Quilometro rodado: ");
                    carro.Quilometro = int.Parse(Console.ReadLine());

                    conec.Open();

                    cmd.Parameters.AddWithValue("Marca", carro.Marca);
                    cmd.Parameters.AddWithValue("Modelo", carro.Modelo);
                    cmd.Parameters.AddWithValue("Cor", carro.Cor);
                    cmd.Parameters.AddWithValue("Pot", carro.Potencia);
                    cmd.Parameters.AddWithValue("Porta", carro.Porta);
                    cmd.Parameters.AddWithValue("Preço", carro.Preço);
                    cmd.Parameters.AddWithValue("Cambio", carro.Cambio);
                    cmd.Parameters.AddWithValue("Traçao", carro.Traçao);
                    cmd.Parameters.AddWithValue("Quilometro", carro.Quilometro);

                    comando = string.Format(@"INSERT 
                                        INTO Carro(Modelo , Potencia , Marca , Cor , Preço , Porta , Cambio , Traçao , Quilometro) 
                                        VALUES (@Modelo, @Potencia, @Marca, @Cor, @Preço , @Porta , @Cambio , @Traçao , @Quilometro);");
                    cmd.CommandText = comando;
                    cmd.ExecuteNonQuery();


                    cmd.Parameters.RemoveAt("Marca");
                    cmd.Parameters.RemoveAt("Modelo");
                    cmd.Parameters.RemoveAt("Cor");
                    cmd.Parameters.RemoveAt("Porta");
                    cmd.Parameters.RemoveAt("Preço");
                    cmd.Parameters.RemoveAt("Cambio");
                    cmd.Parameters.RemoveAt("Traçao");
                    cmd.Parameters.RemoveAt("Quilometro");

                    conec.Close();
                    Console.WriteLine("Efetuado com sucesso");
                }
                if (x == 2)
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Por qual requisito dejesa deleter um veiculo?");
                    Console.WriteLine("*[1-Modelo] [2-Potencia] [3-Marca] [4-Cor] [5-Preço] [6-Numero de portas] [7-Cambio] [8-Traçao] [9-Id]*");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.Write("Resposta: ");
                    j = int.Parse(Console.ReadLine());

                    if (j == 1)
                    {
                        Console.Write("   Digite o modelo: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("modelo", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Modelo = @modelo";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("modelo");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 2)
                    {
                        Console.Write("   Digite a potencia maxima: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("potencia", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Potencia = @potencia";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("potencia");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 3)
                    {
                        Console.Write("   Digite a marca: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("marca", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Marca = @marca";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("marca");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 4)
                    {
                        Console.Write("   Digite a cor: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("cor", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Cor = @cor";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("cor");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 5)
                    {
                        Console.Write("   Digite o preço maximo: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("preço", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Preço = @preço";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("preço");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 6)
                    {
                        Console.Write("   Digite o numero de portas: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("portas", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Portas = @portas";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("portas");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 7)
                    {
                        Console.Write("   Digite o tipo de cambio: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("cambio", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Cambio = @cambio";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("cambio");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 8)
                    {
                        Console.Write("   Digite o tipo de traçao: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("traçao", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Traçao = @traçao";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("Traçao");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                    if (j == 9)
                    {
                        Console.Write("   Digite o id: ");
                        n = Console.ReadLine();

                        cmd.Parameters.AddWithValue("id", n);

                        conec.Open();
                        cmd.CommandText = @"DELETE FROM Carro
                                            WHERE Id = @id";
                        cmd.ExecuteNonQuery();
                        conec.Close();

                        cmd.Parameters.RemoveAt("Id");

                        Console.WriteLine("Efetuado com sucesso");
                    }
                }
                if (x == 3)
                {
                    cmd.CommandText = "SELECT * from Carro";
                    conec.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(0);
                            string Modelo = reader.GetString(1);
                            int Potencia = reader.GetInt32(2);
                            string Marca = reader.GetString(3);
                            string Cor = reader.GetString(4);
                            int Preço = reader.GetInt32(5);
                            int Porta = reader.GetInt32(6);
                            string Cambio = reader.GetString(7);
                            string Traçao = reader.GetString(8);
                            int Quilometro = reader.GetInt32(9);
                            Console.WriteLine("*[{0} = Id] [{1} = Modelo] [{2} = Potencia] [{3} = Marca] [{4} = Cor] [{5} = Preço] [{6} = Numero de portas] [{7} = Cambio] [{8} = Traçao] [{9} = Quilometro]*", Id, Modelo, Potencia, Marca, Cor, Preço , Porta , Cambio , Traçao , Quilometro);
                        }
                    }
                    conec.Close();
                    Console.WriteLine("Efetuado com sucesso");
                }
                if (x == 4)
                {
                    Console.Write("   Digite o id do carro: ");
                    int Cid = int.Parse(Console.ReadLine());

                    Console.Write("   Marca: ");
                    carro.Marca = Console.ReadLine();

                    Console.Write("   Modelo: ");
                    carro.Modelo = Console.ReadLine();

                    Console.Write("   Cor: ");
                    carro.Cor = Console.ReadLine();

                    Console.Write("   Preço: ");
                    carro.Preço = int.Parse(Console.ReadLine());

                    Console.Write("   Potencia: ");
                    carro.Potencia = int.Parse(Console.ReadLine());

                    Console.Write("   Numero de portas: ");
                    carro.Porta = int.Parse(Console.ReadLine());

                    Console.Write("   Cambio: ");
                    carro.Cambio = Console.ReadLine();

                    Console.Write("   Traçao: ");
                    carro.Traçao = Console.ReadLine();

                    Console.Write("   Quilometro rodado: ");
                    carro.Quilometro = int.Parse(Console.ReadLine());

                    conec.Open();

                    cmd.Parameters.AddWithValue("Id", Cid);
                    cmd.Parameters.AddWithValue("Marca", carro.Marca);
                    cmd.Parameters.AddWithValue("Modelo", carro.Modelo);
                    cmd.Parameters.AddWithValue("Cor", carro.Cor);
                    cmd.Parameters.AddWithValue("Pot", carro.Potencia);
                    cmd.Parameters.AddWithValue("Porta", carro.Porta);
                    cmd.Parameters.AddWithValue("Preço", carro.Preço);
                    cmd.Parameters.AddWithValue("Cambio", carro.Cambio);
                    cmd.Parameters.AddWithValue("Traçao", carro.Traçao);
                    cmd.Parameters.AddWithValue("Quilometro", carro.Quilometro);

                    comando = string.Format(@"UPDATE CARRO 
                                        SET Modelo = @Modelo , Potencia = @Potencia , Marca = @Marca , Cor = @Cor , Preço = @Preço , Porta = @Porta , Cambio = @Cambio , Traçao = @Traçao, Quilometro = @Quilometro
                                        WHERE Id = @Id");
                    cmd.CommandText = comando;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("Id");
                    cmd.Parameters.RemoveAt("Marca");
                    cmd.Parameters.RemoveAt("Modelo");
                    cmd.Parameters.RemoveAt("Cor");
                    cmd.Parameters.RemoveAt("Porta");
                    cmd.Parameters.RemoveAt("Preço");
                    cmd.Parameters.RemoveAt("Cambio");
                    cmd.Parameters.RemoveAt("Traçao");
                    cmd.Parameters.RemoveAt("Quilometro");

                    conec.Close();
                    Console.WriteLine("Efetuado com sucesso");
                }
                if (x == 5)
                {

                    Console.WriteLine("   Insira os dados do funcionario: ");

                    Console.Write("   Nome: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.Write("   CPF: ");
                    funcionario.Cpf = Console.ReadLine();

                    Console.Write("   Endereço: ");
                    funcionario.Endereço = Console.ReadLine();

                    Console.Write("   Sexo: ");
                    funcionario.Sexo= char.Parse(Console.ReadLine());

                    Console.Write("   Salario: ");
                    funcionario.Salario = int.Parse(Console.ReadLine());

                    conec.Open();

                    cmd.Parameters.AddWithValue("Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("CPF", funcionario.Cpf);
                    cmd.Parameters.AddWithValue("Endereço", funcionario.Endereço);
                    cmd.Parameters.AddWithValue("Sexo", funcionario.Sexo);
                    cmd.Parameters.AddWithValue("Salario", funcionario.Salario);

                    comando = string.Format(@"INSERT 
                                        INTO Funcionario(Nome , CPF , Endereço , Sexo , Salario) 
                                        VALUES (@Nome , @CPF , @Endereço , @Sexo , @Salario);");
                    cmd.CommandText = comando;
                    cmd.ExecuteNonQuery();


                    cmd.Parameters.RemoveAt("Nome");
                    cmd.Parameters.RemoveAt("CPF");
                    cmd.Parameters.RemoveAt("Endereço");
                    cmd.Parameters.RemoveAt("Sexo");
                    cmd.Parameters.RemoveAt("Salario");

                    conec.Close();
                    Console.WriteLine("Efetuado com sucesso");
                }
                if (x == 6)
                {
                    Console.Write("Digite o ID do funcionario: ");
                    int id = int.Parse(Console.ReadLine());

                    cmd.Parameters.AddWithValue("id", id);

                    conec.Open();
                    cmd.CommandText = @"DELETE FROM Funcionario
                                            WHERE Id = @id";
                    cmd.ExecuteNonQuery();
                    conec.Close();

                    cmd.Parameters.RemoveAt("Id");

                    Console.WriteLine("Efetuado com sucesso");
                }
                if (x == 7)
                {
                    cmd.CommandText = "SELECT * from Funcionario";
                    conec.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(0);
                            string Nome = reader.GetString(1);
                            string Cpf = reader.GetString(2);
                            string Endereço = reader.GetString(3);
                            char Sexo = reader.GetChar(4);
                            int Salario = reader.GetInt32(5);

                            Console.WriteLine("*[{0} = Id] [{1} = Nome] [{2} = CPF] [{3} = Endereço] [{4} = Sexo] [{5} = Salario]*", Id, Nome , Cpf , Endereço , Sexo , Salario);
                        }
                    }
                    conec.Close();
                    Console.WriteLine("Efetuado com sucesso");
                }
                if (x == 8)
                {
                    Console.Write("   Digite o id do funcionario: ");
                    int Fid = int.Parse(Console.ReadLine());

                    Console.Write("   Nome: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.Write("   Cpf: ");
                    funcionario.Cpf = Console.ReadLine();

                    Console.Write("   Endereço: ");
                    funcionario.Endereço = Console.ReadLine();

                    Console.Write("   Sexo: ");
                    funcionario.Sexo = char.Parse(Console.ReadLine());

                    Console.Write("   Salario: ");
                    funcionario.Salario = int.Parse(Console.ReadLine());

                    conec.Open();

                    cmd.Parameters.AddWithValue("Id", Fid);
                    cmd.Parameters.AddWithValue("Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("Cpf", funcionario.Cpf);
                    cmd.Parameters.AddWithValue("Endereço", funcionario.Endereço);
                    cmd.Parameters.AddWithValue("Sexo", funcionario.Sexo);
                    cmd.Parameters.AddWithValue("Salario", funcionario.Salario);

                    comando = string.Format(@"UPDATE Funcionario
                                        SET Nome = @Nome , Cpf = @Cpf , Endereço = @Endereço , Sexo = @Sexo , Salario = @Salario
                                        WHERE Id = @Id");
                    cmd.CommandText = comando;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("Id");
                    cmd.Parameters.RemoveAt("Nome");
                    cmd.Parameters.RemoveAt("CPF");
                    cmd.Parameters.RemoveAt("Endereço");
                    cmd.Parameters.RemoveAt("Sexo");
                    cmd.Parameters.RemoveAt("Salario");
 
                    conec.Close();
                    Console.WriteLine("Efetuado com sucesso");
                }
            }
        }
    }
}
