using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoasAlgoritmo
{
    internal class VerificarMaisVelho
    {

        public void Verificar(Pessoa[] p)
        {
            Pessoa MaisVelha;
           
            for (int i = 0; i < p.Length - 1; i++)
            {
                for (int j = 0; j < p.Length - i - 1; j++)
                {
                    if (p[j].GetIdade() > p[j + 1].GetIdade())
                    {
                        Pessoa temp = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = temp;
                    }
                }
            }

            for( int i = 0;i < p.Length; i++ )
            {
                Console.WriteLine($"{p[i]}");
            }
            
            MaisVelha = p[p.Length - 1];

            Console.WriteLine($"\nPessoa mais velha:\n {MaisVelha}");
            Console.ReadLine();
        }
    }
}
