using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Pais
    {
        public static string NombreTabla = "utilidades_pais";
        public static string NombreCampoId = "utilidades_pais.id";
        public static string NombreCampoNombre = "utilidades_pais.nombre";
        public static string NombreCampoEsactivo = "utilidades_pais.esactivo";

        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public Pais() { }

        public Pais(int id,string nombre,bool esactivo)
        {
            Id=id;
            Nombre=nombre;
            Esactivo=esactivo;
        }
    }
}
