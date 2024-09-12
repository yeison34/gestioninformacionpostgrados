using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Utilidades
{
    public class CiudadModel
    {
        public int Id { get; set; }
        public int? Iddepartamento { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public CiudadModel() { }

        public CiudadModel(int id, int? iddepartamento, string nombre, bool esactivo)
        {
            Id = id;
            Iddepartamento = iddepartamento;
            Nombre = nombre;
            Esactivo = esactivo;
        }
    }
}
