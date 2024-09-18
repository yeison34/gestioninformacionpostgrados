using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class Vistapersona
    {
        public static string NombreTabla = "persona_vistapersona";
        public static string NombreCampoId = "persona_vistapersona.id";
        public static string NombreCampoIdtipoidentificacion = "persona_vistapersona.idtipoidentificacion";
        public static string NombreCampoCedula = "persona_vistapersona.cedula";
        public static string NombreCampoNombres = "persona_vistapersona.nombres";
        public static string NombreCampoApellidos = "persona_vistapersona.apellidos";
        public static string NombreCampoIdgenero = "persona_vistapersona.idgenero";
        public static string NombreCampoFechanacimiento = "persona_vistapersona.fechanacimiento";
        public static string NombreCampoIdpais = "persona_vistapersona.idpais";
        public static string NombreCampoIddepartamento = "persona_vistapersona.iddepartamento";
        public static string NombreCampoIdciudad = "persona_vistapersona.idciudad";
        public static string NombreCampoCorreo = "persona_vistapersona.correo";
        public static string NombreCampoTelefono = "persona_vistapersona.telefono";
        public static string NombreCampoIdusuario = "persona_vistapersona.idusuario";
        public static string NombreCampoGenero = "persona_vistapersona.genero";
        public static string NombreCampoTipoidentificacion = "persona_vistapersona.tipoidentificacion";
        public static string NombreCampoPais = "persona_vistapersona.pais";
        public static string NombreCampoDepartamento = "persona_vistapersona.departamento";
        public static string NombreCampoCiudad = "persona_vistapersona.ciudad";
        public int Id { get; set; }

        public int? Idtipoidentificacion { get; set; }

        public string Cedula { get; set; }
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public int? Idgenero { get; set; }

        public DateTime? Fechanacimiento { get; set; }

        public int? Idpais { get; set; }

        public int? Iddepartamento { get; set; }

        public int? Idciudad { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }
        public int? Idusuario { get; set; }

        public string Genero { get; set; }

        public string Tipoidentificacion { get; set; }

        public string Pais { get; set; }

        public string Departamento { get; set; } 
        
        public string Ciudad { get; set; }

        public Vistapersona() { }

        public Vistapersona(int id, int? idtipoidentificacion, string cedula, string nombres, string apellidos, int? idgenero, DateTime? fechanacimiento, int? idpais, int? iddepartamento, int? idciudad, string correo, string telefono, int? idusuario,string genero,string tipoidentificacion,string pais,string departamento, string ciudad)
        {
            Id = id;
            Idtipoidentificacion = idtipoidentificacion;
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Idgenero = idgenero;
            Fechanacimiento = fechanacimiento;
            Idpais = idpais;
            Iddepartamento = iddepartamento;
            Idciudad = idciudad;
            Correo = correo;
            Telefono = telefono;
            Idusuario = idusuario;
            Genero= genero;
            Tipoidentificacion = tipoidentificacion;
            Pais= pais;
            Departamento= departamento;
            Ciudad=ciudad;
        }
    }
}
