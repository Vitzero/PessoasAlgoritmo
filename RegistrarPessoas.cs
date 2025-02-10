using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoasAlgoritmo
{
    internal class RegistrarPessoas
    {
        public Pessoa[] RegistrarPessoa()
        {
            string nome;
            int idade,cpf;
            int escolha = 0;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.WriteLine($"Digite quantas pessoas quer registrar: (no mínimo 5!)");
                        escolha = int.Parse(Console.ReadLine());

                    } while (escolha < 5);

                    break;

                }
               
                #region catchs
                catch (FormatException)
                {
                    Console.WriteLine("Digite valores válidos!");
                    Console.ReadLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Número longo demais!");
                }
                catch (Exception ex)
                {
                    throw new Exception("erro inesperado.." + ex);
                }
            }
            #endregion

            Pessoa[] p = new Pessoa[escolha];

            Console.WriteLine($"digite a informação de {escolha} pessoas: ");
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Digite o nome da pessoa {i + 1}:");
                nome = Console.ReadLine();

                
                while (true)
                {
                    idade = 0;
                    try
                    {
                        Console.WriteLine("digite o CPF:");
                        cpf = int.Parse(Console.ReadLine());


                        Console.WriteLine("Digite a idade:");
                        idade = int.Parse(Console.ReadLine());
                        break;
                    }
                    #region catchs2
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite números para a idade e cpf!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Número longo demais para idade e cpf!");
                    }
                    #endregion
                }
                p[i] = new Pessoa(nome, cpf, idade);
            }

            return p;
        }

    }
}
