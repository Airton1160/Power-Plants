using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaPlants.DAL
{
    public class Coneccao
    {
        // string de coneccao
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["strconn"].ConnectionString;

        // AO DECLARAR UMA VARIABVEL COMO "static" TORNA-SE VISIVEL PARA TODOS USUARIOS LOGADOS NO SISTEMA 

        public static SqlConnection conect = new SqlConnection(connectionString);

        // ABRE A CONEXAO COM BANCO DDADOS
        public static void Conectar()
        {
            // ABRINDO CONEXAO SE ESTIVER FECHADA

            if (conect.State == System.Data.ConnectionState.Closed)
            {
                conect.Open();
            }
        }
        // FECHA A CONEXAO 
        public static void Desconectar()
        {
            // FECHA CONEXAO SE ESTIVER ABERTA

            if (conect.State == System.Data.ConnectionState.Open)
            {
                conect.Close();
            }
        }
    }
}