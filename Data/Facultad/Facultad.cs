using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Facultad
{
    public partial class Facultad
    {
        public static string NombreTabla = "facultad_facultad";
        public static string NombreCampoId = "facultad_facultad.id";
        public static string NombreCodigo = "facultad_facultad.codigo";
        public static string NombreNombre = "facultad_facultad.nombre";
        public static string NombreEsactivo = "facultad_facultad.esactivo";

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public Facultad() { 

        }

        public Facultad(int id, string codigo, string nombre, bool esactivo)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Esactivo= esactivo;
        }
    }
}
