using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Programa
{
    public class ResponseModel
    {
        [NotMapped]
        public bool exito { get; set; }
        [NotMapped]
        public string descripcion { get; set; }

        [NotMapped]
        public string icon { get; set; }


        public ResponseModel() { }

        public ResponseModel(bool exito, string descripcion, string icon)
        {
            this.exito = exito;
            this.descripcion = descripcion;
            this.icon = icon;

        }
    }
}
