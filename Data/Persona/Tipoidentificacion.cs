using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class Tipoidentificacion
    {
        public static string NombreTabla = "persona_tipoidentificacion";
        public static string NombreCampoId = "persona_tipoidentificacion.id";
        public static string NombreCampoNombre = "persona_tipoidentificacion.nombre";
        public static string NombreCampoEsactivo = "persona_tipoidentificacion.esactivo";

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public Tipoidentificacion() { }

        public Tipoidentificacion(int id,string nombre,bool esactivo)
        {
            Id=id;
            Nombre=nombre;
            Esactivo=esactivo;
        }
    }
}
