using Data.Persona;
using Data.Utilidades;
using Entities.Persona;
using Negocio.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Web;
using System.Web.Mvc;

namespace PostgradosGestionInformacion.Controllers.Persona
{
    [Authorize]
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<VistapersonaModel> usuarios = null;
            try
            {
                usuarios = VistapersonaData.getRegistros().Select(x => new VistapersonaModel(x.Id,x.Idtipoidentificacion,x.Cedula,x.Nombres,x.Apellidos,x.Idgenero,x.Fechanacimiento,x.Idpais,x.Iddepartamento,x.Idciudad,x.Correo,x.Telefono,x.Idusuario,x.Genero,x.Tipoidentificacion,x.Pais,x.Departamento,x.Ciudad)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                Connection.closeConnection();
            }
            return View(usuarios);
        }

        public ActionResult Edicion(int id) {
            PersonaEdicionModel persona=new PersonaEdicionModel();
            try {
                persona = PersonaNegocio.ObtenerInformacionCompletaPersona(id);
            }catch(Exception ex)
            {
                throw ex;
            }
            finally {
                Connection.closeConnection();
            }
            return View(persona);
        }

        [HttpPost]
        public ActionResult Guardar(PersonaEdicionModel model)
        {
            try {
                model=PersonaNegocio.GuardarInformacionPersona(model);                
            }
            catch(Exception ex)
            {
                throw;
            }
            finally { 
                Connection.closeConnection(); 
            }
            return View("Edicion",model);
        }
    }
}