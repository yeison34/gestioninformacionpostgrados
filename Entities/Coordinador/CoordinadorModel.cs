using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Coordinador
{
    public class CoordinadorModel
    {
        public int Id { get; set; }
        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public string Acuerdonombramiento { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public CoordinadorModel()
        {

        }

        public CoordinadorModel(int id, int? idpersona, int? idprogrma, DateTime? fechavinculacion, string acuerdonombramiento, bool esactivo, bool esvinculado)
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
