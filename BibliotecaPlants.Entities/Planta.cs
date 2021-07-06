using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPlants.Entities
{
    public class Planta : ChaveID
    {
        public int OrigemID { get; set; }
        public int TipoID { get; set; }
        public string Titulo { get; set; }
        public double? Preco { get; set; }
        public DateTime? DataEntrada { get; set; }
        public string Imagem { get; set; }
    }
}
