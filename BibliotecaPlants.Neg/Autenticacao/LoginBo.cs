using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaPlants.Entities;
using BibliotecaPlants.BLL.Exceptions;
using BibliotecaPlants.DAL;

namespace BibliotecaPlants.BLL.Autenticacao
{
    public class LoginBo
    {
         // VERIFICAR SE O USUARIO ESTA CADASTRADO

        private UsuarioDAO _usuarioDAO;

        public Usuario VerificaUser(string nomeUsuario, string senha)
        {
            //instanciacao 
            _usuarioDAO = new UsuarioDAO();
            var usuario = _usuarioDAO.ObterUserPorUsuarioSenha(nomeUsuario, senha);
            if (usuario == null)
            {
                // EXCECAO JA TRATADA
                throw new Usuario_nao_Cadastrado();
            }
            //  SE NAO RETORNA O USUARIO PESQUISADO
            else
            {
                return usuario;
            }
        }
    }
}
