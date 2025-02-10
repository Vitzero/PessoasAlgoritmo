using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoasAlgoritmo
{
    internal class Pessoa
    {
        private string Nome { get; set; }
        private int Cpf { get; set; }
        private int Idade { get; set; }

        public Pessoa(string nome,int cpf,int idade) { 
            Nome = nome;
            Cpf = cpf;
            Idade = idade;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, CPF: {Cpf}";
        }
   
    }
}
