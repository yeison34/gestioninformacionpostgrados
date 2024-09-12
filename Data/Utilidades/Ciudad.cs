using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Ciudad
    {
        public static string NombreTabla = "utilidades_ciudad";
        public static string NombreCampoId = "utilidades_ciudad.id";
        public static string NombreCampoIddepartamento = "utilidades_ciudad.iddepartamento";
        public static string NombreCampoNombre = "utilidades_ciudad.nombre";
        public static string NombreCampoEsactivo = "utilidades_ciudad.esactivo";

        public int Id { get; set; }
        public int? Iddepartamento { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public Departamento Idpaisidpais
        {
            get {
                return DepartamentoData.getRegistroPorId(Iddepartamento??0);
            }
        }
        public Ciudad() { }

        public Ciudad(int id,int? iddepartamento,string nombre,bool esactivo)
        {
            Id=id;
            Iddepartamento= iddepartamento;
            Nombre=nombre;
            Esactivo=esactivo;
        }
    }
}
