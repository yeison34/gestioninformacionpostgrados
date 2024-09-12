using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Persona
{
    public class PersonaModel
    {
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

        public PersonaModel(int id, int? idtipoidentificacion, string cedula, string nombres, string apellidos, int? idgenero, DateTime? fechanacimiento, int? idpais, int? iddepartamento, int? idciudad, string correo, string telefono, int? idusuario)
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
        }
    }
}
