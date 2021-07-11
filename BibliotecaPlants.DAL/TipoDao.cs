using BibliotecaPlants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaPlants.DAL
{
    public class TipoDao
    {
        public List<Tipo> ObterTodosTipos()
        {
            try
            {
                //instanciar a classe sqlcommand
                var command = new SqlCommand();
                //coloca a variavel criada . connection recebendo a classe e o nome da variavel da string de coneccao com banco
                command.Connection = Coneccao.conect;
                //agora vem o select para os dados feito no banco com strings T-sql
                command.CommandText = "SELECT * FROM Tipos ORDER BY descricao";
                // e conectar ...
                Coneccao.Conectar();
                //fazendo leitura dos dados
                var reader = command.ExecuteReader();
                var tipos = new List<Tipo>();

                while (reader.Read())
                {
                    var tipo = new Tipo();

                    tipo.ID = Convert.ToInt32(reader["ID"]);
                    tipo.Descricao = reader["descricao"].ToString();

                    tipos.Add(tipo);
                }
                Coneccao.Desconectar();
                return tipos;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
