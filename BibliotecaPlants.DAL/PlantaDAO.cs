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
                Coneccao.Desconectar();
                // retorna os jogos que foram adicionados
                return plantas;
            }

            catch (Exception)
            {

                throw;
            }

        }

        // o int he para retornar quantas linhas foram afetadas, "uma caracteristica de qdo insere um registro!
        // ele vai retornar a quantidades de linhas inseridas para ser tratadas na camada de negocios no plantasBo"
        public int InserirPlanta(Planta planta)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Coneccao.conect;
                command.CommandText =
                                      @" INSERT INTO [dbo].[Plantas]
                                          ([origemID] , [tipoID] ,[titulo] , [preco] , [data] , [imagem])
                                      VALUES
                                          (@ID_ORIGEM
                                          ,@ID_TIPO
                                          ,@TITULO
                                          ,@PRECO
                                          ,@DATA
                                          ,@IMAGEM)";

                command.Parameters.AddWithValue("@TITULO", planta.Titulo);
                command.Parameters.AddWithValue("@ID_ORIGEM", planta.OrigemID);
                command.Parameters.AddWithValue("@ID_TIPO", planta.TipoID);
                command.Parameters.AddWithValue("@PRECO", planta.Preco);
                command.Parameters.AddWithValue("@DATA", planta.DataEntrada);
                command.Parameters.AddWithValue("@IMAGEM", planta.Imagem);

                Coneccao.Conectar();
                return command.ExecuteNonQuery();
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
