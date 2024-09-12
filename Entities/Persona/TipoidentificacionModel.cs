using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Persona
{
    public class TipoidentificacionModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public TipoidentificacionModel() { }

        public TipoidentificacionModel(int id, string nombre, bool esactivo)
        {
            Id = id;
            Nombre = nombre;
            Esactivo = esactivo;
        }
    }
}
