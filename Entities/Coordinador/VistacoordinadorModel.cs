using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Coordinador
{
    public class VistacoordinadorModel
    {
        public int Id { get; set; }

        public int? Idpersona { get; set; }
        public int? Idprograma { get; set; }
        public DateTime? Fechavinculacion { get; set; }
        public string Acuerdonombramiento { get; set; }
        public bool Esactivo { get; set; }

        public bool Esvinculado { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Nombreprograma { get; set; }
        public VistacoordinadorModel()
        {

        }

        public VistacoordinadorModel(int id, int? idpersona, int? idprogrma, DateTime? fechavinculacion, string acuerdonombramiento, bool esactivo, bool esvinculdo, string cedula, string nombre, string nombreprograma)
        {
            Id = id;
            Idpersona = idpersona;
            Idprograma = idprogrma;
            Fechavinculacion = fechavinculacion;
            Acuerdonombramiento = acuerdonombramiento;
            Esactivo = esactivo;
            Esvinculado = esvinculdo;
            Cedula = cedula;
            Nombre = nombre;
            Nombreprograma = nombreprograma;
        }
    }
}
