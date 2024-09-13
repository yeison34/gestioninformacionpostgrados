using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Facultad
{
    public class FacultadModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public FacultadModel()
        {

        }

        public FacultadModel(int id, string codigo, string nombre, bool esactivo)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Esactivo = esactivo;
        }
    }
}
