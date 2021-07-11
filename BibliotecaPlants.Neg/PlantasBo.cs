using BibliotecaPlants.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaPlants.Entities;
using BibliotecaPlants.BLL;
using BibliotecaPlants.BLL.Exceptions;

namespace BibliotecaPlants.BLL
{
    public class PlantasBo
    {
        private PlantaDAO _plantaDAO;
        public List<Planta> AllPlants()
        {
            _plantaDAO = new PlantaDAO();
            return _plantaDAO.AllPlants();
        }
        public void InserirNovaPlanta(Planta planta)
        {
            _plantaDAO = new PlantaDAO();
            ValidarPlanta(planta);
            // aqui as linhas afetadas sera igual inserirplanta passando planta como parametro
            var linhasAfetadas = _plantaDAO.InserirPlanta(planta);

            if (linhasAfetadas == 0)
            {
                throw new PlantaNaoCadastrada();
            }
        }

        // metodo separado
        public void ValidarPlanta(Planta planta)
        {
            if (string.IsNullOrWhiteSpace(planta.Titulo) ||
                    planta.TipoID == 0 ||
                    planta.OrigemID == 0)
                    {
                         throw new PlantaInvalida();
                    }
        }
    }
}
