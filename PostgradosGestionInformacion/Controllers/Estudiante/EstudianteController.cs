using Data.Coordinador;
using Data.Estudiante;
using Data.Utilidades;
using Entities.Coordinador;
using Entities.Estudiante;
using Negocio.Coordinador;
using Negocio.Estudiante;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostgradosGestionInformacion.Controllers.Estudiante
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            List<VistaestudianteModel> model = null;
            try
            {
                model = VistaestudianteData.getRegistros().Select(x => new VistaestudianteModel(x.Id,x.Codigo, x.Idpersona, x.Idprograma,x.Idcohorte, x.Fechavinculacion, x.Esactivo, x.Esvinculado, x.Nombreprograma, x.Nombrecohorte, x.Cedula,x.Nombre)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View(model);
        }

        public ActionResult Edicion(int idpersona) {
            EstudianteEditModel model = new EstudianteEditModel();
            try
            {
                model = EstudianteNegocio.ObtenerInformacionEstudiantePorId(0, idpersona);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View();
        }

        public ActionResult Estudiante(int idpersona)
        {
            EstudianteEditModel model = new EstudianteEditModel();
            try
            {
                model = EstudianteNegocio.ObtenerInformacionEstudiantePorId(0, idpersona);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View("Edicion", model);
        }

        public ActionResult VincularEstudiante(EstudianteEditModel model)
        {
            try
            {
                //model.Acuerdonombramiento = GuardarAcuerdoNombramiento(model.fileAcuerdo, model.Idpersona ?? 0);
                model = EstudianteNegocio.VincularEstudiante(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View("CoordinacionEdicion", model);
        }

        private string GuardarAcuerdoNombramiento(HttpPostedFileBase file, int idpersona)
        {
            string nombrearchivo = "";
            try
            {
                if (file != null && file.ContentLength > 0)
                {
                    var nombreFile = $"{Guid.NewGuid()}{Path.GetFileName(file.FileName)}";
                    var path = Path.Combine(Server.MapPath("~/Acuerdos"), nombreFile);
                    nombrearchivo = nombreFile;
                    file.SaveAs(path);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nombrearchivo;
        }
    }
}