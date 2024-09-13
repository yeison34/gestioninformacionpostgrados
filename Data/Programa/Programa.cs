using Data.Facultad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Programa
{
    public partial class Programa
    {
        public static string NombreTabla = "programa_programa";
        public static string NombreCampoId = "programa_programa.id";
        public static string NombreCodigo = "programa_programa.codigo";
        public static string NombreNombre = "programa_programa.nombre";
        public static string NombreIdFacultad = "programa_programa.idfacultad";
        public static string NombreEsPregrado = "programa_programa.espregrado";
        public static string NombreEsPostgrado = "programa_programa.espostgrado";
        public static string NombreEsactivo = "programa_programa.esactivo";

        public int Id {  get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdFacultad { get; set; }
        public bool EsPregrado { get; set; }
        public bool EsPostgrado { get;set; }
        public bool EsActivo { get; set; }


        public Data.Facultad.Facultad Idfacultaidfacultad
        {
            get
            {
                return FacultadData.getRegistroPorId(IdFacultad??0);
            }
        }
        public Programa() { }

        public Programa(int id, string codigo, string nombre, int? idfacultad, bool espregrado, bool espostgrado, bool esactivo)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.IdFacultad = idfacultad;
            this.EsPregrado = espregrado;
            this.EsPostgrado= espostgrado;
            this.EsActivo = esactivo;
        }


    }
}
