using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPlants.Entities
{
    public class Usuario : ChaveID
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public char Perfil { get; set; }
    }
}
