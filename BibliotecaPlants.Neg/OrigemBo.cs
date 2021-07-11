using BibliotecaPlants.DAL;
using BibliotecaPlants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPlants.BLL
{
    public class OrigemBo
    {
        private OrigemDao _origemDao;

        public List<Origem> ObterOrigem()
        {
            _origemDao = new OrigemDao();
            return _origemDao.ObterOrigem();
        }


    }
}
