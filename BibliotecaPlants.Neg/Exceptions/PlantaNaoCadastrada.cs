using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPlants.BLL.Exceptions
{
    // 1 passo herda de exception
    public class PlantaNaoCadastrada : Exception
    {
        // 2 passo herda de base()
        public PlantaNaoCadastrada() : base()
        {

        }
    }
}
