using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Entities.Programa
{
    public class ProgramaLstModel
    {
        [NotMapped]
        public List<ProgramaModel> registros { get; set; }
        [NotMapped]
        public ResponseModel response { get; set; }


        public ProgramaLstModel() { }

        public ProgramaLstModel(List<ProgramaModel> registros, ResponseModel response)
        {
            this.registros = registros;
            this.response = response;
        }

    }
}
