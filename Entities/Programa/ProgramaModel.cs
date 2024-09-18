using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Entities.Programa
{
    public class ProgramaModel
    {
        public int Id { get; set; }
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
        public bool EsPostgrado { get; set; }
        public bool EsActivo { get; set; }

        [NotMapped]
        public HttpPostedFileBase ArchivoPath { get; set; }
        [NotMapped]
        public HttpPostedFileBase LogoPath { get; set; }

        public ProgramaModel() { }

        public ProgramaModel(int id, string codigo, string nombre, int? idfacultad,string corre, string descripcion, string lineastrabajo, DateTime fecha, string numerores, string archivores, string logo, bool espregrado, bool espostgrado, bool esactivo)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.IdFacultad = idfacultad;
            this.Correo = corre;
            this.Descripcion = descripcion;
            this.LineasTrabajo = lineastrabajo;
            this.Fecha = fecha;
            this.NumeroRes = numerores;
            this.ArchivoRes = archivores;
            this.Logo = logo;
            this.EsPregrado = espregrado;
            this.EsPostgrado = espostgrado;
            this.EsActivo = esactivo;
        }


    
}
}
