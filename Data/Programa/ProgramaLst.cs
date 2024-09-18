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
    public partial class ProgramaLSt
    {
        [NotMapped]
        public List<Programa> registros { get; set; }
        [NotMapped]
        public Response response { get; set; }


        public ProgramaLSt() { }

        public ProgramaLSt(List<Programa> registros, Response response)
        {
            this.registros = registros;
            this.response = response;
        }


    }
}
