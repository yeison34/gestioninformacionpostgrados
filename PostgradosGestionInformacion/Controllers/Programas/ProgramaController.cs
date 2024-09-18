using Data.Facultad;
using Data.Persona;
using Data.Programa;
using Data.Utilidades;
using Entities.Facultad;
using Entities.Persona;
using Entities.Programa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PostgradosGestionInformacion.Controllers
{

    public class ProgramaController : Controller
    {
        // GET: Programa
        public ActionResult Index(ResponseModel response)
        {
            //List<ProgramaModel> programas = null;
            ProgramaLstModel programas = new ProgramaLstModel();
            
            try
            {
                programas.registros = ProgramaData.getRegistros().Select(x => new ProgramaModel(x.Id, x.Codigo, x.Nombre, x.IdFacultad,x.Correo,x.Descripcion,x.LineasTrabajo,x.Fecha,x.NumeroRes,x.ArchivoRes,x.Logo, x.EsPregrado, x.EsPostgrado, x.EsActivo)).ToList();
                programas.response = new ResponseModel();
                if (response != null){
                    programas.response = response;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View(programas);
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
                    model.Correo = programa.Correo;
                    model.Descripcion = programa.Descripcion;
                    model.LineasTrabajo = programa.LineasTrabajo;
                    model.Fecha = programa.Fecha;
                    model.NumeroRes = programa.NumeroRes;
                    model.ArchivoRes = programa.ArchivoRes;
                    model.Logo = programa.Logo;
                    model.EsPregrado = programa.EsPregrado;
                    model.EsPostgrado = programa.EsPostgrado;
                    model.EsActivo = programa.EsActivo;
                }
 
                // Aquí agregamos las opciones para el menú de selección
                model.ListaCategorias = new List<SelectListItem>
                {
                        new SelectListItem { Value = "Ingeniería de Software", Text = "Ingeniería de Software" },
                        new SelectListItem { Value = "IoT y Tecnologías 4.0", Text = "IoT y Tecnologías 4.0" },
                        new SelectListItem { Value = "Ciencia de Datos", Text = "Ciencia de Datos" },
                        new SelectListItem { Value = "Inteligencia Artificial", Text = "Inteligencia Artificial" }
                };

                model.ListaFacultades = FacultadData.getRegistros()
                    .Where(p => p.Esactivo)
                    .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Nombre })
                    .ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Connection.closeConnection();
            }
            return View(model);
        }



        [HttpPost]
        public ActionResult Guardar(ProgramaEditModel programa)
        {
            ResponseModel response = new ResponseModel();
            if (!ModelState.IsValid)
            {
                return View("Edicion");
            }

            if ((programa.ArchivoPath != null && programa.ArchivoPath.ContentLength > 0) &&
                (programa.LogoPath != null && programa.LogoPath.ContentLength > 0))
            {
                try
                {
                    string pathImg = "~/Images/Logos_Programas/";
                    string pathArch = "~/Images/Archivo_Programas/";

                    // Convertir rutas relativas a rutas físicas del servidor
                    string imgDirectory = Server.MapPath(pathImg);
                    string archDirectory = Server.MapPath(pathArch);

                    // Verificar si los directorios existen, y si no, crearlos
                    if (!Directory.Exists(imgDirectory))
                    {
                        Directory.CreateDirectory(imgDirectory);
                    }

                    if (!Directory.Exists(archDirectory))
                    {
                        Directory.CreateDirectory(archDirectory);
                    }

                    // Procesar y guardar el logotipo
                    string fileName = Path.GetFileNameWithoutExtension(programa.LogoPath.FileName);
                    string extension = Path.GetExtension(programa.LogoPath.FileName);
                    string fullFileName = fileName + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + extension;
                    string rutaLogo = Path.Combine(Server.MapPath(pathImg), fullFileName);
                    programa.LogoPath.SaveAs(rutaLogo);
                    programa.Logo = Path.Combine(pathImg, fullFileName);

                    // Procesar y guardar el archivo asociado
                    string fileName2 = Path.GetFileNameWithoutExtension(programa.ArchivoPath.FileName);
                    string extension2 = Path.GetExtension(programa.ArchivoPath.FileName);
                    string fullFileName2 = fileName2 + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + extension2;
                    string rutaArchivo = Path.Combine(Server.MapPath(pathArch), fullFileName2);
                    programa.ArchivoPath.SaveAs(rutaArchivo);
                    programa.ArchivoRes = Path.Combine(pathArch, fullFileName2);

                    var progamamodel = new Programa(programa.Id, programa.Codigo, programa.Nombre, programa.IdFacultad, programa.Correo, programa.Descripcion, programa.LineasTrabajo, programa.Fecha, programa.NumeroRes, programa.ArchivoRes, programa.Logo, programa.EsPregrado, programa.EsPostgrado, programa.EsActivo);

                    if (programa.Id != 0)
                    {
                       var responseI = ProgramaData.actualizarRegistro(progamamodel);
                        response = new ResponseModel(responseI.exito, responseI.descripcion, responseI.css_class);
                    }
                    else
                    {
                        var responseI = ProgramaData.insertarRegistro(progamamodel);
                        programa.Id = progamamodel.Id;
                        response = new ResponseModel(responseI.exito, responseI.descripcion, responseI.css_class);

                    }
                }
                catch (Exception)
                {
                    response = new ResponseModel(true, "Error De Datos", "error");
                }
                finally
                {
                    Connection.closeConnection();
                }

                return RedirectToAction("Index", response);
            }

            return View("Edicion");
        }
        public ActionResult Eliminar(int id)
        {
            ResponseModel response = new ResponseModel();

            try
            {
                var responseI = ProgramaData.EliminarRegistro(id);
                response = new ResponseModel(responseI.exito, responseI.descripcion, responseI.css_class);
            }
            catch (Exception e) {
                response = new ResponseModel(true, "Error al eliminar ", "error");
            }
            return RedirectToAction("Index", response);
        }

    }
}