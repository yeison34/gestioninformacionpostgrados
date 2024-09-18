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
    public partial class Estudiante
    {
        public static string NombreTabla = "estudiante_estudiante";
        public static string NombreCampoId = "estudiante_estudiante.id";
        public static string NombreCampoCodigo = "estudiante_estudiante.codigo";
        public static string NombreCampoIdPersona = "estudiante_estudiante.idpersona";
        public static string NombreCampoIdPrograma = "estudiante_estudiante.idprograma";
        public static string NombreCampoIdcohorte = "estudiante_estudiante.idcohorte";
        public static string NombreCampoFechaVinculacion = "estudiante_estudiante.fechavinculacion";
        public static string NombreCampoEsactivo = "estudiante_estudiante.esactivo";
        public static string NombreCampoEsVinculado = "estudiante_estudiante.esvinculado";
        public static string NombreCampoIdProgramacursa = "estudiante_estudiante.idprogramacursa";
        public static string NombreCampoIdSemestre = "estudiante_estudiante.idsemestre";
        public static string NombreCampoFechaIngreso = "estudiante_estudiante.fechaingreso";
        public static string NombreCampoFechaEgreso = "estudiante_estudiante.fechaegreso";
        public static string NombreCampoEsEgresado = "estudiante_estudiante.esgresado";
        public int Id { get; set; }

        public string Codigo { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }

        public int? Idcohorte { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public int? Idprogramacursa { get; set; }

        public int? Idsemestre { get; set; }

        public DateTime? Fechaingreso { get; set; }

        public DateTime? Fechaegreso { get; set; }

        public bool Esegresado { get; set; }

        public Data.Persona.Persona Idpersonaidpersona
        {
            get
            {
                return PersonaData.getRegistroPorId(Idpersona ?? 0);
            }
        }

        public Data.Programa.Programa Idprogramaidprograma
        {
            get
            {
                return ProgramaData.getRegistroPorId(Idprograma ?? 0);
            }
        }

        public Data.Cohorte.Cohorte Idcohorteidcohorte
        {
            get {
                return CohorteData.getRegistroPorId(Idcohorte??0);
            }
        }

        public Data.Programa.Programa Idprogramacursaidprogramacursa
        {
            get {
                return ProgramaData.getRegistroPorId(Idprogramacursa??0);
            }
        }

        public Estudiante()
        {

        }

        public Estudiante(int id, string codigo,int? idpersona, int? idprograma, int? idcohorte,DateTime? fechavinculacion, bool esactivo, bool esvinculdo)
        {
            Id = id;
            Codigo = codigo;
            Idpersona = idpersona;
            Idprograma = idprograma;
            Idcohorte = idcohorte;
            Fechavinculacion = fechavinculacion;
            Esactivo = esactivo;
            Esvinculado = esvinculdo;
        }
    }
}
