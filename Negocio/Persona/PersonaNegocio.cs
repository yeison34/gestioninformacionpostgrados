using Data;
using Data.Persona;
using Data.Utilidades;
using Entities.Persona;
using Entities.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Negocio.Persona
{
    public partial class PersonaNegocio
    {
        public static PersonaEdicionModel ObtenerInformacionCompletaPersona(int id)
        {
            PersonaEdicionModel persona = new PersonaEdicionModel();
            try
            {
                if (id != 0)
                {
                    Data.Persona.Persona informacionPersona = PersonaData.getRegistroPorId(id);
                    persona.Id = informacionPersona.Id;
                    persona.Idtipoidentificacion = informacionPersona.Idtipoidentificacion;
                    persona.Cedula = informacionPersona.Cedula;
                    persona.Nombres = informacionPersona.Nombres;
                    persona.Apellidos = informacionPersona.Apellidos;
                    persona.Idgenero = informacionPersona.Idgenero;
                    persona.Fechanacimiento = informacionPersona.Fechanacimiento;
                    persona.Idpais = informacionPersona.Idpais;
                    persona.Iddepartamento = informacionPersona.Iddepartamento;
                    persona.Idciudad = informacionPersona.Idciudad;
                    persona.Correo = informacionPersona.Correo;
                    persona.Telefono = informacionPersona.Telefono;
                    persona.Idusuario = informacionPersona.Idusuario;
                }
                persona.Paises = PaisData.getRegistros().Where(x => x.Esactivo).Select(x => new SelectListItem { Value=x.Id.ToString(),Text=x.Nombre}).ToList();
                persona.Departamentos = DepartamentoData.getRegistros().Where(x => x.Esactivo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre }).ToList();
                persona.Ciudades = CiudadData.getRegistros().Where(x => x.Esactivo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre }).ToList();
                persona.TiposIdentificacion = TipoidentificacionData.getRegistros().Where(x => x.Esactivo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre }).ToList();
                persona.Generos = GeneroData.getRegistros().Where(x => x.Esactivo).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre }).ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
            return persona;
        }

        public static PersonaEdicionModel GuardarInformacionPersona(PersonaEdicionModel model)
        {
            PersonaEdicionModel personaEdicion = new PersonaEdicionModel();
            try
            {
                Data.Persona.Persona persona = new Data.Persona.Persona(model.Id,model.Idtipoidentificacion,model.Cedula,model.Nombres,model.Apellidos,model.Idgenero,model.Fechanacimiento,model.Idpais,model.Iddepartamento,model.Idciudad,model.Correo,model.Telefono,model.Idusuario);
                if (persona.Id == 0)
                {
                    PersonaData.insertarRegistro(persona);
                }
                else {
                    PersonaData.actualizarRegistro(persona);
                }
                personaEdicion = ObtenerInformacionCompletaPersona(model.Id);
            }
            catch (Exception ex) {
                throw ex;
            }
            return personaEdicion;
        }
    }
}
