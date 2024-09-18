using Data.Persona;
using Data.Programa;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Coordinador
{
    public partial class Vistacoordinador
    {
        public static string NombreTabla = "coordinador_vistacoordinador";
        public static string NombreCampoId = "coordinador_vistacoordinador.id";
        public static string NombreCampoIdPersona = "coordinador_vistacoordinador.idpersona";
        public static string NombreCampoIdPrograma = "coordinador_vistacoordinador.idprograma";
        public static string NombreCampoFechaVinculacion = "coordinador_vistacoordinador.fechavinculacion";
        public static string NombreCampoAcuerdoNombramiento = "coordinador_vistacoordinador.acuerdonombramiento";
        public static string NombreCampoEsactivo = "coordinador_vistacoordinador.esactivo";
        public static string NombreCampoEsVinculado = "coordinador_vistacoordinador.esvinculado";
        public static string NombreCampoCedula = "coordinador_vistacoordinador.cedula";
        public static string NombreCampoNombre = "coordinador_vistacoordinador.nombre"; 
        public static string NombreCampoNombreprograma = "coordinador_vistacoordinador.nombreprograma";

        public int Id { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public string Acuerdonombramiento { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Nombreprograma { get; set; }
        public Vistacoordinador()
        {

        }

        public Vistacoordinador(int id, int? idpersona, int? idprogrma, DateTime? fechavinculacion, string acuerdonombramiento, bool esactivo, bool esvinculdo,string cedula,string nombre, string nombreprograma)
        {
            Id = id;
            Idpersona = idpersona;
            Idprograma = idprogrma;
            Fechavinculacion = fechavinculacion;
            Acuerdonombramiento = acuerdonombramiento;
            Esactivo = esactivo;
            Esvinculado = esvinculdo;
            Cedula= cedula;
            Nombre = nombre;
            Nombreprograma = nombreprograma;
        }
    }
}
