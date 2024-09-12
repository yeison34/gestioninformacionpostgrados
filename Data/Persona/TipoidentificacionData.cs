using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class TipoidentificacionData
    {
        public static string SelectTabla() { 
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT persona_tipoidentificacion.id, persona_tipoidentificacion.nombre, persona_tipoidentificacion.esactivo FROM persona_tipoidentificacion");
            return sql.ToString();
        }
        public static List<Tipoidentificacion> getRegistros()
        {
            List<Tipoidentificacion> registros = null;
            try { 
                StringBuilder sql=new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Tipoidentificacion>(sql.ToString()).ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Tipoidentificacion getRegistroPorId(int id)
        {
            Tipoidentificacion registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append(" persona_tipoidentificacion.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Tipoidentificacion>(sql.ToString(),parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
