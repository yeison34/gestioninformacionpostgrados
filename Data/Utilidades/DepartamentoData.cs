using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utilidades
{
    public partial class DepartamentoData
    {
        public static string SelectTabla() { 
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT utilidades_departamento.id, utilidades_departamento.idpais,utilidades_departamento.nombre, utilidades_departamento.esactivo FROM utilidades_departamento");
            return sql.ToString();
        }
        public static List<Departamento> getRegistros()
        {
            List<Departamento> registros = null;
            try { 
                StringBuilder sql=new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Departamento>(sql.ToString()).ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Departamento getRegistroPorId(int id)
        {
            Departamento registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append(" utilidades_departamento.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Departamento>(sql.ToString(),parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
