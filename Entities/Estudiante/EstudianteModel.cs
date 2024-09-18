using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Estudiante
{
    public class EstudianteModel
    {
        public int Id { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }

        public int? Idcohorte { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public EstudianteModel()
        {

        }

        public EstudianteModel(int id, int? idpersona, int? idprograma, int? idcohorte, DateTime? fechavinculacion, bool esactivo, bool esvinculdo)
        {
            Id = id;
            Idpersona = idpersona;
            Idprograma = idprograma;
            Idcohorte = idcohorte;
            Fechavinculacion = fechavinculacion;
            Esactivo = esactivo;
            Esvinculado = esvinculdo;
        }
    }
}
