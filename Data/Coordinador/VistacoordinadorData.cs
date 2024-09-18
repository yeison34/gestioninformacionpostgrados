using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Coordinador
{
    public partial class VistacoordinadorData
    {
        public static string SelectTabla()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT coordinador_vistacoordinador.id,coordinador_vistacoordinador.idpersona,coordinador_vistacoordinador.idprograma,coordinador_vistacoordinador.fechavinculacion,coordinador_vistacoordinador.acuerdonombramiento,coordinador_vistacoordinador.esactivo,coordinador_vistacoordinador.esvinculado,coordinador_vistacoordinador.cedula,coordinador_vistacoordinador.nombre,coordinador_vistacoordinador.nombreprograma FROM coordinador_vistacoordinador ");
            return sql.ToString();
        }

        public static List<Vistacoordinador> getRegistros()
        {
            List<Vistacoordinador> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Vistacoordinador>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }
    }
}
