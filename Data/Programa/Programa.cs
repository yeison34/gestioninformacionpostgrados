using Data.Facultad;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Data.Programa
{
    public partial class Programa
    {
        public static string NombreTabla = "programa_programa";
        public static string NombreCampoId = "programa_programa.id";
        public static string NombreCodigo = "programa_programa.codigo";
        public static string NombreNombre = "programa_programa.nombre";
        public static string NombreIdFacultad = "programa_programa.idfacultad";
        public static string NombreCorreo = "programa_programa.correo";
        public static string NombreDescripcion = "programa_programa.descripcion";
        public static string NombreLineasTrabajo = "programa_programa.lineastrabajo";
        public static string NombreFecha = "programa_programa.fecha";
        public static string NombreNumeroRes = "programa_programa.numerores";
        public static string NombreArchivoRes = "programa_programa.archivores";
        public static string NombreLogo = "programa_programa.logo";
        public static string NombreEsPregrado = "programa_programa.espregrado";
        public static string NombreEsPostgrado = "programa_programa.espostgrado";
        public static string NombreEsactivo = "programa_programa.esactivo";

        public int Id {  get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdFacultad { get; set; }
        public string Correo { get; set; }
        public string Descripcion { get; set; }
        public string LineasTrabajo { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroRes { get; set; }
        public string ArchivoRes { get; set; }
        public string Logo { get; set; }
        public bool EsPregrado { get; set; }
        public bool EsPostgrado { get;set; }
        public bool EsActivo { get; set; }

        [NotMapped]
        public HttpPostedFileBase ArchivoPath { get; set; }
        [NotMapped]
        public HttpPostedFileBase LogoPath { get; set; }

        public Data.Facultad.Facultad Idfacultaidfacultad
        {
            get
            {
                return FacultadData.getRegistroPorId(IdFacultad??0);
            }
        }
        public Programa() { }

        public Programa(int id, string codigo, string nombre, int? idfacultad,string email, string descripcion,string lineastrabajo,DateTime fecha,string numerores, string archivores, string logo, bool espregrado, bool espostgrado, bool esactivo)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.IdFacultad = idfacultad;
            this.Correo = email;
            this.Descripcion = descripcion;
            this.LineasTrabajo = lineastrabajo;
            this.Fecha = fecha;
            this.NumeroRes = numerores;
            this.ArchivoRes = archivores;
            this.Logo = logo;
            this.EsPregrado = espregrado;
            this.EsPostgrado= espostgrado;
            this.EsActivo = esactivo;
        }


    }
}
