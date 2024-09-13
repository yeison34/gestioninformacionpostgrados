using Data.Facultad;
using Data.Programa;
using Data.Utilidades;
using Entities.Facultad;
using Entities.Programa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostgradosGestionInformacion.Controllers
{
    public class ProgramaController : Controller
    {
        // GET: Programa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edicion(int id)
        {
            ProgramaEditModel model = new ProgramaEditModel();

            try
            {
                if (id != 0)
                {
                    var programa = ProgramaData.getRegistroPorId(id);
                    model.Id = programa.Id;
                    model.Codigo = programa.Codigo;
                    model.Nombre = programa.Nombre;
                    model.IdFacultad = programa.IdFacultad;
                    model.EsPregrado = programa.EsPregrado;
                    model.EsPostgrado = programa.EsPostgrado;
                    model.EsActivo = programa.EsActivo;
                }
                model.ListaFacultades = FacultadData.getRegistros().Where(p => p.Esactivo).Select(p => new SelectListItem {Value = p.Id.ToString(),Text = p.Nombre }).ToList();
            }
            catch (Exception e){
                throw e;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Guardar(ProgramaEditModel programa) {
            try
            {
                var progamamodel = new Programa(programa.Id, programa.Codigo, programa.Nombre, programa.IdFacultad, programa.EsPregrado, programa.EsPostgrado, programa.EsActivo);
                if (programa.Id != 0)
                {
                    ProgramaData.actualizarRegistro(progamamodel);
                }
                else
                {
                    ProgramaData.insertarRegistro(progamamodel);
                    programa.Id = progamamodel.Id;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { 
                Connection.closeConnection();
            }
            return View("Edicion",programa);
        }
    }
}