using BibliotecaPlants.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaPlants.Entities;

namespace BibliotecaPlants.BLL.Autenticacao
{
    public class PlantasBo
    {
        private PlantaDAO _plantaDAO;
        public List<Planta> AllPlants()
        {
            _plantaDAO = new PlantaDAO();
            return _plantaDAO.AllPlants(); 
        }
    }
}
