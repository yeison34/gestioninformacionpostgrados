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
    public partial class Response
    {
       
        public static bool Exito= false;
        public static string Descripcion = "Descripcion del error";

        [NotMapped]
        public bool exito {  get; set; }
        [NotMapped]
        public string descripcion { get; set; }

        [NotMapped]
        public string css_class { get; set; }


        public Response() { }

        public Response( bool exito, string descripcion, string css) { 
            this.exito = exito;
            this.descripcion = descripcion;
            this.css_class = css;
  
        }


    }
}
