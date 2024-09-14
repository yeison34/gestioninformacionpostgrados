using Data.Persona;
using Data.Programa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Coordinador
{
    public partial class Coordinador
    {
        public static string NombreTabla = "coordinador_coordinador";
        public static string NombreCampoId = "coordinador_coordinador.id";
        public static string NombreCampoIdPersona = "coordinador_coordinador.idpersona";
        public static string NombreCampoIdPrograma = "coordinador_coordinador.idprograma";
        public static string NombreCampoFechaVinculacion = "coordinador_coordinador.fechavinculacion";
        public static string NombreCampoAcuerdoNombramiento = "coordinador_coordinador.acuerdonombramiento";
        public static string NombreCampoEsactivo = "coordinador_coordinador.esactivo";
        public static string NombreCampoEsVinculado = "coordinador_coordinador.esvinculado";
        

        public int Id { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public string Acuerdonombramiento { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public Data.Persona.Persona Idpersonaidpersona
        {
            get {
                return PersonaData.getRegistroPorId(Idpersona??0);
            }
        }

        public Data.Programa.Programa Idprogramaidprograma
        {
            get {
                return ProgramaData.getRegistroPorId(Idprograma??0);
            }
        }

        public Coordinador()
        {

        }

        public Coordinador(int id, int? idpersona, int? idprogrma, DateTime? fechavinculacion,string acuerdonombramiento,bool esactivo,bool esvinculdo)
        {
            Id = id;
            Idpersona = idpersona;
            Idprograma= idprogrma;
            Fechavinculacion= fechavinculacion;
            Acuerdonombramiento= acuerdonombramiento;
            Esactivo = esactivo;
            Esvinculado= esvinculdo;
        }
    }
}
