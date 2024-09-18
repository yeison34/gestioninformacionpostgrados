using Data.Coordinador;
using Data.Programa;
using Entities.Coordinador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Negocio.Coordinador
{
    public partial class CoordinadorNegocio
    {
        public static CoordinadorEditModel ObtenerInformacionVinculacionCoordinadorPorId(int id,int? idpersona)
        {
            CoordinadorEditModel coordinador=new CoordinadorEditModel();    
            try
            {
                if (id != 0)
                {
                    var coordinadorModel = CoordinadorData.getRegistroPorId(id);
                    coordinador.Id = coordinadorModel.Id;
                    coordinador.Idpersona = coordinadorModel.Idpersona;
                    coordinador.Idprograma = coordinadorModel.Idprograma;
                    coordinador.Fechavinculacion = coordinadorModel.Fechavinculacion;
                    coordinador.Acuerdonombramiento = coordinadorModel.Acuerdonombramiento;
                    coordinador.Esactivo = coordinadorModel.Esactivo;
                    coordinador.Esvinculado = coordinadorModel.Esvinculado;
                }
                else {
                    coordinador.Idpersona = idpersona;
                }
                coordinador.ListaProgramas = ProgramaData.getRegistros().Where(x=>x.EsActivo).Select(x=>new System.Web.Mvc.SelectListItem { Value = x.Id.ToString(), Text = $"{x.Codigo} - {x.Nombre}" }).ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
            return coordinador;
        }

        public static CoordinadorEditModel VincularCoordinador(CoordinadorEditModel model)
        {
            try
            {
                var coordinador = new Data.Coordinador.Coordinador(model.Id, model.Idpersona, model.Idprograma, model.Fechavinculacion, model.Acuerdonombramiento, model.Esactivo, model.Esvinculado);
                if (model.Id != 0)
                {
                    CoordinadorData.actualizarRegistro(coordinador);
                    
                }
                else
                {
                    coordinador.Esactivo = true;
                    coordinador.Esvinculado = true;
                    CoordinadorData.insertarRegistro(coordinador);
                    model.Id = coordinador.Id;
                }
                model = ObtenerInformacionVinculacionCoordinadorPorId(model.Id,null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }
    }
}
