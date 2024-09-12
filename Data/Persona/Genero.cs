using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class Genero
    {
        public static string NombreTabla = "persona_genero";
        public static string NombreCampoId = "persona_genero.id";
        public static string NombreCampoNombre = "persona_genero.nombre";
        public static string NombreCampoEsactivo = "persona_genero.esactivo";

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public Genero() { }

        public Genero(int id,string nombre,bool esactivo)
        {
            Id=id;
            Nombre=nombre;
            Esactivo=esactivo;
        }
    }
}
