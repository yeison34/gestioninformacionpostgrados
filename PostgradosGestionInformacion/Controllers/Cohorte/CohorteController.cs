using Data.Cohorte;
using Data.Utilidades;
using Entities.Cohorte;
using Negocio.Cohorte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PostgradosGestionInformacion.Controllers
{
    public class CohorteController : Controller
    {

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guardar(CohorteModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model=CohorteNegocio.GuardarCohorte(model);
                    TempData["SuccessMessage"] = "¡Proceso exitosamente!";
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al crear la cohorte: " + ex.Message);
                }
            }

            return View("Edicion",model);
        }
        public ActionResult Index()
        {
            List<CohorteModel> cohortes = null;
            try
            {
                cohortes=CohorteData.GetCohortes().Select(x => new CohorteModel(x.Id, x.Nombre, x.FechaResolucion, x.FechaFinalizacion, x.NumeroEstudiantes, x.EsActiva)).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 
            
                Connection.closeConnection();   
            }
            return View(cohortes);
        }

        public ActionResult Edicion(int id) {
            CohorteModel model = new CohorteModel();
            try
            {
                model = CohorteNegocio.ObtenerInformacionVinculacionCoordinadorPorId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 
                Connection.closeConnection();
            }
            return View(model);
        }
    }
}
