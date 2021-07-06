using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaPlants.Entities;


namespace BibliotecaPlants.DAL
{
    public class UsuarioDAO
    {
        public Usuario ObterUserPorUsuarioSenha(string Nomeusuario, string senha)
        {
            try
            {
                var sqlcmd = new SqlCommand();
                sqlcmd.Connection = Coneccao.conect;
                sqlcmd.CommandText = "SELECT * FROM USUARIOS WHERE USUARIO = @USUARIO AND SENHA = @SENHA";

                sqlcmd.Parameters.AddWithValue("@USUARIO", Nomeusuario);
                sqlcmd.Parameters.AddWithValue("@SENHA", senha);

                
                Coneccao.Conectar();

                //          LEITOR DOS PARAMETROS ADQUIRIDOS PELA QUERY

                var reader = sqlcmd.ExecuteReader();
                Usuario usuario = null;

                while (reader.Read())
                {
                    usuario = new Usuario();

                    //          MAPEAMENTO NO BANCO DE DADOS NAS COLUNAS FAZENDO LOOP - TEM Q CONVERTER POIS VEM DO BANCO COMO OBJ.

                    usuario.ID = (int)reader["ID"];
                    usuario.NomeUsuario = reader["usuario"].ToString();
                    usuario.Senha = reader["senha"].ToString();
                    usuario.Perfil = Convert.ToChar(reader["perfil"]);
                }
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Coneccao.Desconectar();
            }
        }
    }
}
