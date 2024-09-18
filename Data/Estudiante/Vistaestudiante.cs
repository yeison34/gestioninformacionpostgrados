using Data.Cohorte;
using Data.Persona;
using Data.Programa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Estudiante
{
    public partial class Vistaestudiante
    {
        public static string NombreTabla = "estudiante_vistaestudiante";
        public static string NombreCampoId = "estudiante_vistaestudiante.id";
        public static string NombreCampoCodigo = "estudiante_vistaestudiante.codigo";
        public static string NombreCampoIdPersona = "estudiante_vistaestudiante.idpersona";
        public static string NombreCampoIdPrograma = "estudiante_vistaestudiante.idprograma";
        public static string NombreCampoIdcohorte = "estudiante_vistaestudiante.idcohorte";
        public static string NombreCampoFechaVinculacion = "estudiante_vistaestudiante.fechavinculacion";
        public static string NombreCampoEsactivo = "estudiante_vistaestudiante.esactivo";
        public static string NombreCampoEsVinculado = "estudiante_vistaestudiante.esvinculado";
        public static string NombreCampoNombreprograma = "estudiante_vistaestudiante.nombreprograma";
        public static string NombreCampoNombrecohorte = "estudiante_vistaestudiante.nombrecohorte";
        public static string NombreCampoCedula = "estudiante_vistaestudiante.cedula";
        public static string NombreCampoNombre = "estudiante_vistaestudiante.nombre";    
            
        public int Id { get; set; }

        public string Codigo { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }

        public int? Idcohorte { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public string Nombreprograma { get; set; }

        public string Nombrecohorte { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }
        public Vistaestudiante()
        {

        }

        public Vistaestudiante(int id, string codigo,int? idpersona, int? idprograma, int? idcohorte, DateTime? fechavinculacion, bool esactivo, bool esvinculdo,string nombreprograma,string nombrecohorte,string cedula,string nombre)
        {
            Id = id;
            Codigo = codigo;
            Idpersona = idpersona;
            Idprograma = idprograma;
            Idcohorte = idcohorte;
            Fechavinculacion = fechavinculacion;
            Esactivo = esactivo;
            Esvinculado = esvinculdo;
            Nombreprograma= nombreprograma;
            Nombrecohorte= nombreprograma;
            Cedula = cedula;
            Nombre = nombre;
        }
    }
}
