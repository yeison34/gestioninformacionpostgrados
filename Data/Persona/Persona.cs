using Data.Usuarios;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class Persona
    {
        public static string NombreTabla = "persona_persona";
        public static string NombreCampoId = "persona_persona.id";
        public static string NombreCampoIdtipoidentificacion = "persona_persona.idtipoidentificacion";
        public static string NombreCampoCedula = "persona_persona.cedula";
        public static string NombreCampoNombres = "persona_persona.nombres";
        public static string NombreCampoApellidos = "persona_persona.apellidos";
        public static string NombreCampoIdgenero = "persona_persona.idgenero";
        public static string NombreCampoFechanacimiento = "persona_persona.fechanacimiento";
        public static string NombreCampoIdpais = "persona_persona.idpais";
        public static string NombreCampoIddepartamento= "persona_persona.iddepartamento";
        public static string NombreCampoIdciudad = "persona_persona.idciudad";
        public static string NombreCampoCorreo = "persona_persona.correo";
        public static string NombreCampoTelefono = "persona_persona.telefono";
        public static string NombreCampoIdusuario = "persona_persona.idusuario";

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

        public Genero Idgeneroidgenero
        {
            get
            {
                return GeneroData.getRegistroPorId(Idgenero??0);
            }
        }

        public Pais Idpaisidpais
        {
            get {
                return PaisData.getRegistroPorId(Idpais??0);
            }
        }

        public Departamento Iddepartamentoiddepartamento
        {
            get {
                return DepartamentoData.getRegistroPorId(Iddepartamento??0);
            }
        }

        public Ciudad Idciudadidciudad
        {
            get {
                return CiudadData.getRegistroPorId(Idciudad??0);
            }
        }
        
        public Usuario Idusuarioidusaurio
        {
            get {
                return UsuarioData.getRegistroPorId(Idusuario??0);
            }
        }

        public Persona(int id,int? idtipoidentificacion,string cedula,string nombres,string apellidos, int? idgenero, DateTime? fechanacimiento, int? idpais, int? iddepartamento, int? idciudad, string correo, string telefono,int? idusuario)
        {
            Id= id;
            Idtipoidentificacion= idtipoidentificacion;
            Cedula= cedula;
            Nombres= nombres;
            Apellidos = apellidos;
            Idgenero = idgenero;
            Fechanacimiento = fechanacimiento;
            Idpais = idpais;
            Iddepartamento = iddepartamento;
            Idciudad = idciudad;
            Correo = correo;
            Telefono = telefono;
            Idusuario = idusuario;
        }


    }
}
