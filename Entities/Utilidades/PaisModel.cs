using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Utilidades
{
    public class PaisModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public PaisModel() { }

        public PaisModel(int id, string nombre, bool esactivo)
        {
            Id = id;
            Nombre = nombre;
            Esactivo = esactivo;
        }
    }
}
