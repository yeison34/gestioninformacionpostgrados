using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class Departamento
    {
        public static string NombreTabla = "utilidades_departamento";
        public static string NombreCampoId = "utilidades_departamento.id";
        public static string NombreCampoIdpais = "utilidades_departamento.idpais";
        public static string NombreCampoNombre = "utilidades_departamento.nombre";
        public static string NombreCampoEsactivo = "utilidades_departamento.esactivo";

        public int Id { get; set; }
        public int? Idpais { get; set; }
        public string Nombre { get; set; }
        public bool Esactivo { get; set; }

        public Pais Idpaisidpais
        {
            get {
                return PaisData.getRegistroPorId(Idpais??0);
            }
        }
        public Departamento() { }

        public Departamento(int id,int? idpais,string nombre,bool esactivo)
        {
            Id=id;
            Idpais=idpais;
            Nombre=nombre;
            Esactivo=esactivo;
        }
    }
}
