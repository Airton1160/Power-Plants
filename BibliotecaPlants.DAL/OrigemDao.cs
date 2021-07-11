using BibliotecaPlants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BibliotecaPlants.DAL
{
    public class OrigemDao
    {
        public List<Origem> ObterOrigem()
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Coneccao.conect;
                command.CommandText = "SELECT * FROM Origem ORDER BY nome";
                Coneccao.Conectar();

                var reader = command.ExecuteReader();
                var origens = new List<Origem>();

                while (reader.Read())
                {
                    var origem = new Origem();

                    origem.ID = Convert.ToInt32(reader["ID"]);
                    origem.Nome = reader["nome"].ToString();

                    origens.Add(origem);
                }
                Coneccao.Desconectar();
                return origens;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
