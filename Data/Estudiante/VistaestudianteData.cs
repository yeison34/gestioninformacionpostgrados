using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Estudiante
{
    public partial class VistaestudianteData
    {
        public static string SelectTabla()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT estudiante_vistaestudiante.id,estudiante_vistaestudiante.codigo,estudiante_vistaestudiante.idpersona,estudiante_vistaestudiante.idprograma,estudiante_vistaestudiante.fechavinculacion,estudiante_vistaestudiante.esactivo,estudiante_vistaestudiante.esvinculado,estudiante_vistaestudiante.nombreprograma,estudiante_vistaestudiante.nombrecohorte,estudiante_vistaestudiante.cedula,estudiante_vistaestudiante.nombre FROM estudiante_vistaestudiante ");
            return sql.ToString();
        }
        public static List<Vistaestudiante> getRegistros()
        {
            List<Vistaestudiante> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Vistaestudiante>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }
    }
}
