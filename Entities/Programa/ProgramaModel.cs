using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Programa
{
    public class ProgramaModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdFacultad { get; set; }
        public bool EsPregrado { get; set; }
        public bool EsPostgrado { get; set; }
        public bool EsActivo { get; set; }

        public ProgramaModel() { }

        public ProgramaModel(int id, string codigo, string nombre, int? idfacultad, bool espregrado, bool espostgrado, bool esactivo)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.IdFacultad = idfacultad;
            this.EsPregrado = espregrado;
            this.EsPostgrado = espostgrado;
            this.EsActivo = esactivo;
        }


    
}
}
