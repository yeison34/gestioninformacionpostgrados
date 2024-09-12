using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class GeneroData
    {
        public static string SelectTabla() { 
            StringBuilder sql= new StringBuilder();
            sql.Append("SELECT persona_genero.id, persona_genero.nombre, persona_genero.esactivo FROM persona_genero");
            return sql.ToString();
        }
        public static List<Genero> getRegistros()
        {
            List<Genero> registros = null;
            try { 
                StringBuilder sql=new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Genero>(sql.ToString()).ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Genero getRegistroPorId(int id)
        {
            Genero registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append(" persona_genero.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                registro = conexion.QueryFirstOrDefault<Genero>(sql.ToString(),parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
