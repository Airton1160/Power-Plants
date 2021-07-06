using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPlants.BLL.Exceptions
{
    public class Usuario_nao_Cadastrado : Exception
    {
        //    TRATAMENTO DAS EXCECOES
        public Usuario_nao_Cadastrado()
        {
        }
        public Usuario_nao_Cadastrado(string message)
            : base(message)
        {

        }
        public Usuario_nao_Cadastrado(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
