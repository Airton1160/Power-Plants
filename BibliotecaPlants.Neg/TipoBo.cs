using BibliotecaPlants.DAL;
using BibliotecaPlants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPlants.BLL
{
    public class TipoBo
    {
        private TipoDao _tipoDao;

        public List<Tipo> ObterTodosTipos()
        {
            _tipoDao = new TipoDao();
            return _tipoDao.ObterTodosTipos();
        }
    }
}
