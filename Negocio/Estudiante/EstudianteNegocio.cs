using Data.Cohorte;
using Data.Coordinador;
using Data.Estudiante;
using Data.Programa;
using Entities.Coordinador;
using Entities.Estudiante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Estudiante
{
    public partial class EstudianteNegocio
    {
        public static EstudianteEditModel ObtenerInformacionEstudiantePorId(int id, int? idpersona)
        {
            EstudianteEditModel estudiante = new EstudianteEditModel();
            try
            {
                if (id != 0)
                {
                    var estudianteModel = EstudianteData.getRegistroPorId(id);
                    estudiante.Id = estudianteModel.Id;
                    estudiante.Codigo = estudianteModel.Codigo;
                    estudiante.Idpersona = estudianteModel.Idpersona;
                    estudiante.Idprograma = estudianteModel.Idprograma;
                    estudiante.Idcohorte = estudianteModel.Idcohorte;
                    estudiante.Fechavinculacion = estudianteModel.Fechavinculacion;
                    estudiante.Esactivo = estudianteModel.Esactivo;
                    estudiante.Esvinculado = estudianteModel.Esvinculado;
                }
                else
                {
                    estudiante.Idpersona = idpersona;
                }
                estudiante.ListaProgramas = ProgramaData.getRegistros().Where(x => x.EsActivo).Select(x => new System.Web.Mvc.SelectListItem { Value = x.Id.ToString(), Text = $"{x.Codigo} - {x.Nombre}" }).ToList();
                estudiante.ListaCohortes = CohorteData.GetCohortes().Where(x => x.EsActiva).Select(x => new System.Web.Mvc.SelectListItem { Value = x.Id.ToString(), Text = x.Nombre }).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return estudiante;
        }

        public static EstudianteEditModel VincularEstudiante(EstudianteEditModel model)
        {
            try
            {
                var estudiante = new Data.Estudiante.Estudiante(model.Id,model.Codigo, model.Idpersona, model.Idprograma,model.Idcohorte, model.Fechavinculacion, model.Esactivo, model.Esvinculado);
                if (model.Id != 0)
                {
                    EstudianteData.actualizarRegistro(estudiante);

                }
                else
                {
                    estudiante.Esactivo = true;
                    estudiante.Esvinculado = true;
                    EstudianteData.insertarRegistro(estudiante);
                    estudiante.Id = estudiante.Id;
                }
                model = ObtenerInformacionEstudiantePorId(model.Id, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }
    }
}
