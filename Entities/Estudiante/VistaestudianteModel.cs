using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Estudiante
{
    public class VistaestudianteModel
    {
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

        public VistaestudianteModel()
        {

        }

        public VistaestudianteModel(int id,string codigo,int? idpersona,int? idprograma, int? idcohorte, DateTime? fechavinculacion, bool esactivo, bool esvinculdo,string nombreprograma,string nombrecohorte,string cedula,string nombre)
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
            Nombrecohorte= nombrecohorte;
            Cedula= cedula;
            Nombre= nombre;
        }
    }
}
