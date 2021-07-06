using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BibliotecaPlants.BLL;
using BibliotecaPlants.BLL.Autenticacao;
using BibliotecaPlants.BLL.Exceptions;

namespace BibliotecaPlants.Site.Autenticacao
{

    public partial class Login : Page
    {
        private LoginBo _loginBo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEntrar_Click1(object sender, EventArgs e)
        {
            _loginBo = new LoginBo();
            
            // pegar valor dos campos
            var senha = txtSenha.Text;
            var nomeUsuario = txtUsuario.Text;

            try
            {

                // botar o usuario p logar
                var usuario = _loginBo.VerificaUser(nomeUsuario, senha);
                FormsAuthentication.RedirectFromLoginPage(nomeUsuario, true);

                // fazendo uma session contornando um erro
                Session.Timeout = 30;
                Session["Perfil"] = usuario.Perfil;


            }
            catch (Usuario_nao_Cadastrado)
            {
                txtstatus.Text = "Usuário nao cadastrado";
            }

            catch (Exception)
            {
                txtstatus.Text = "erro inesperado!!";
            }


        }
    }
}