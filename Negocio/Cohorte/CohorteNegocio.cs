using Data.Cohorte;
using Data.Coordinador;
using Data.Programa;
using Entities.Cohorte;
using Entities.Coordinador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Negocio.Cohorte
{
    public partial class CohorteNegocio
    {
        public static CohorteModel ObtenerInformacionVinculacionCoordinadorPorId(int id)
        {
            CohorteModel cohorte =new CohorteModel();    
            try
            {
                if (id != 0)
                {
                    var coordinadorModel = CohorteData.getRegistroPorId(id);
                    cohorte.Id = coordinadorModel.Id;
                    cohorte.Nombre = coordinadorModel.Nombre;
                    cohorte.FechaResolucion = coordinadorModel.FechaResolucion;
                    cohorte.FechaFinalizacion = coordinadorModel.FechaFinalizacion;
                    cohorte.NumeroEstudiantes = coordinadorModel.NumeroEstudiantes;
                    cohorte.EsActiva = coordinadorModel.EsActiva;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
            return cohorte;
        }

        public static CohorteModel GuardarCohorte(CohorteModel model)
        {
            try
            {
                var cohorte = new Data.Cohorte.Cohorte(model.Id, model.Nombre,model.FechaResolucion,model.FechaFinalizacion,model.NumeroEstudiantes,model.EsActiva);
                if (model.Id != 0)
                {
                    CohorteData.actualizarRegistro(cohorte);
                    
                }
                else
                {
                    model.EsActiva = true;
                    CohorteData.CrearCohorte(cohorte);
                    model.Id = cohorte.Id;
                }
                model = ObtenerInformacionVinculacionCoordinadorPorId(model.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }
    }
}
