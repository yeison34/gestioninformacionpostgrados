using Entities.Programa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;

namespace Entities.Coordinador
{
    public class CoordinadorEditModel
    {
        public int Id { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public string Acuerdonombramiento { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public HttpPostedFileBase fileAcuerdo { get; set; }
        public List<SelectListItem> ListaProgramas { get; set; }
        public CoordinadorEditModel()
        {
            ListaProgramas= new List<SelectListItem>();  
        }

        public CoordinadorEditModel(int id, int? idpersona, int? idprogrma, DateTime? fechavinculacion, string acuerdonombramiento, bool esactivo, bool esvinculado)
        {
            Id = id;
            Idpersona = idpersona;
            Idprograma = idprogrma;
            Fechavinculacion = fechavinculacion;
            Acuerdonombramiento = acuerdonombramiento;
            Esactivo = esactivo;
            Esvinculado = esvinculado;
        }
    }
}
