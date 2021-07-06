using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaPlants.Entities;
using System.Data.SqlClient;

namespace BibliotecaPlants.DAL
{
    public class PlantaDAO
    {
        public List<Planta> AllPlants()
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Coneccao.conect;
                command.CommandText = "SELECT * FROM Plantas";

                Coneccao.Conectar();

                var reader = command.ExecuteReader();
                var plantas = new List<Planta>();

                while (reader.Read())
                {
                    var planta = new Planta();

                    planta.ID = Convert.ToInt32(reader["ID"]);
                    planta.Imagem = reader["imagem"].ToString();
                    planta.DataEntrada = reader["data"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data"]);
                    planta.Titulo = reader["titulo"].ToString();
                    planta.Preco = reader["preco"] == DBNull.Value ? (Double?)null : Convert.ToDouble(reader["preco"]);

                    plantas.Add(planta);
                }
                command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                // retorna os jogos que foram adicionados
                return plantas;
            }

            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
