using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Utilidades
{
    public class DepartamentoModel
    {
        public int Id { get; set; }
        public int? Idpais { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public DepartamentoModel() { }

        public DepartamentoModel(int id, int? idpais, string nombre, bool esactivo)
        {
            Id = id;
            Idpais = idpais;
            Nombre = nombre;
            Esactivo = esactivo;
        }
    }
}
