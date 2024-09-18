using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Entities.Estudiante
{
    public class EstudianteEditModel
    {
        public int Id { get; set; }

        public string Codigo { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }

        public int? Idcohorte { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public List<SelectListItem> ListaProgramas { get; set; }

        public List<SelectListItem> ListaCohortes { get; set; }
        public EstudianteEditModel()
        {
            ListaProgramas= new List<SelectListItem>();
            ListaCohortes= new List<SelectListItem>();
        }

        public EstudianteEditModel(int id, string codigo,int? idpersona, int? idprograma, int? idcohorte, DateTime? fechavinculacion, bool esactivo, bool esvinculdo)
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
