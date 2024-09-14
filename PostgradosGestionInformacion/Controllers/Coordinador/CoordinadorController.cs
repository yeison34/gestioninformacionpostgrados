
using Data.Utilidades;
using Entities.Coordinador;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostgradosGestionInformacion.Controllers.Coordinador
{
    public class CoordinadorController : Controller
    {
        // GET: Coordinador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CoordinacionEdicion(int id) {
            CoordinadorEditModel model = new CoordinadorEditModel();
            try
            {
                model = CoordinadorNegocio.ObtenerInformacionVinculacionCoordinadorPorId(id,null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                Connection.closeConnection();
            }
            return View();
        }

        public ActionResult Coordinador(int idpersona)
        {
            CoordinadorEditModel model = new CoordinadorEditModel();
            try
            {
                model = CoordinadorNegocio.ObtenerInformacionVinculacionCoordinadorPorId(0,idpersona);
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

        public ActionResult VincularCoordinador(CoordinadorEditModel model)
        {
            try
            {
                model.Acuerdonombramiento = GuardarAcuerdoNombramiento(model.fileAcuerdo,model.Idpersona??0);
                model = CoordinadorNegocio.VincularCoordinador(model);
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

        private string GuardarAcuerdoNombramiento(HttpPostedFileBase file,int idpersona)
        {
            string nombrearchivo = "";
            try
            {
                if (file!=null && file.ContentLength>0) {
                    var nombreFile = $"{Guid.NewGuid()}{Path.GetFileName(file.FileName)}";
                    var path = Path.Combine(Server.MapPath("~/Acuerdos"),nombreFile);
                    nombrearchivo = nombreFile;
                    file.SaveAs(path);
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            return nombrearchivo;
        }
    }
}