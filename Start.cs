using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoasAlgoritmo
{
    internal static class Start
    {
        public static void startar()
        {
            RegistrarPessoas registrar = new RegistrarPessoas();

            Pessoa[] pessoas = registrar.RegistrarPessoa();

            VerificarMaisVelho verificar = new VerificarMaisVelho();

            verificar.Verificar(pessoas);

        }
    }
}
