using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class CiudadData
    {
        public static string SelectTabla() { 
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT utilidades_ciudad.id, utilidades_ciudad.iddepartamento,utilidades_ciudad.nombre, utilidades_ciudad.esactivo FROM utilidades_ciudad");
            return sql.ToString();
        }
        public static List<Ciudad> getRegistros()
        {
            List<Ciudad> registros = null;
            try { 
                StringBuilder sql=new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Ciudad>(sql.ToString()).ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Ciudad getRegistroPorId(int id)
        {
            Ciudad registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append(" utilidades_ciudad.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Ciudad>(sql.ToString(),parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
