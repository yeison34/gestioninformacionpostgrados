using Entities.Utilidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Entities.Persona
{
    public class PersonaEdicionModel
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

        public List<SelectListItem> Ciudades { get; set; }

        public List<SelectListItem> Departamentos { get; set; }

        public List<SelectListItem> Paises { set; get; }
         
        public List<SelectListItem> TiposIdentificacion { get; set; }

        public List<SelectListItem> Generos { get; set; }


        public PersonaEdicionModel(int id, int? idtipoidentificacion, string cedula, string nombres, string apellidos, int? idgenero, DateTime? fechanacimiento, int? idpais, int? iddepartamento, int? idciudad, string correo, string telefono, int? idusuario)
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

        public PersonaEdicionModel() {
            Ciudades = new List<SelectListItem>();
            Departamentos = new List<SelectListItem>();
            Paises=new List<SelectListItem>();
            TiposIdentificacion = new List<SelectListItem>();
            Generos = new List<SelectListItem>();
        }

    }
}
