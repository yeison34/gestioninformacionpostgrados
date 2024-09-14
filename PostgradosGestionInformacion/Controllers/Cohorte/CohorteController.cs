using Data.Models;
using Data.PersonaModel;
using Data.Utilidades;
using PostgradosGestionInformacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PostgradosGestionInformacion.Controllers
{
    public class CohorteController : Controller
    {
        public ActionResult CrearCohorte()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearCohorte(CohorteModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cohorte = new Cohorte(
                        0,
                        model.Nombre,
                        model.FechaResolucion,
                        model.FechaFinalizacion,
                        model.NumeroEstudiantes,
                        model.EsActiva
                    );

                    CohorteData.CrearCohorte(cohorte);

                    TempData["SuccessMessage"] = "¡La cohorte fue creada exitosamente!";
                    return RedirectToAction("CrearCohorte");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al crear la cohorte: " + ex.Message);
                }
            }

            return View(model);
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


        //public ActionResult EditarCohorte(int id)
        //{
        //    var cohorte = CohorteData.GetCohortes().FirstOrDefault(c => c.Codigo == id);
        //    if (cohorte == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    var model = new CohorteModel(
        //        cohorte.Codigo,
        //        cohorte.Nombre,
        //        cohorte.FechaResolucion,
        //        cohorte.FechaFinalizacion,
        //        cohorte.NumeroEstudiantes,
        //        cohorte.EsActiva
        //    );

        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult EditarCohorte(CohorteModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var cohorte = new Cohorte(
        //                model.Codigo,
        //                model.Nombre,
        //                model.FechaResolucion,
        //                model.FechaFinalizacion,
        //                model.NumeroEstudiantes,
        //                model.EsActiva
        //            );

        //            CohorteData.ActualizarCohorte(cohorte);

        //            TempData["SuccessMessage"] = "¡La cohorte fue actualizada exitosamente!";
        //            return RedirectToAction("Index");
        //        }
        //        catch (Exception ex)
        //        {
        //            ModelState.AddModelError("", "Error al actualizar la cohorte: " + ex.Message);
        //        }
        //    }

        //    return View(model);
        //}
    }
}
