using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Coordinador
{
    public partial class CoordinadorData
    {
        public static string SelectTabla()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT coordinador_coordinador.id,coordinador_coordinador.idpersona,coordinador_coordinador.idprograma,coordinador_coordinador.fechavinculacion,coordinador_coordinador.acuerdonombramiento,coordinador_coordinador.esactivo,coordinador_coordinador.esvinculado FROM coordinador_coordinador ");
            return sql.ToString();
        }

        public static Coordinador insertarRegistro(Coordinador registro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO coordinador_coordinador (id,idpersona,idprograma,fechavinculacion,acuerdonombramiento,esactivo,esvinculado)");
                sql.Append(" VALUES (@id,@idpersona,@idprograma,@fechavinculacion,@acuerdonombramiento,@esactivo,@esvinculado)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('coordinador_coordinador_id_seq'::regclass)");
                registro.Id = id;
                conexion.Execute(sql.ToString(), registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static void actualizarRegistro(Coordinador registro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE coordinador_coordinador ");
                sql.Append("set id=@id, idpersona=@idpersona, idprograma=@idprograma, fechavinculacion=@fechavinculacion, acuerdonombramiento=@acuerdonombramiento, esactivo=@esactivo, esvinculado=@esvinculado");
                sql.Append(" WHERE id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(), registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Coordinador> getRegistros()
        {
            List<Coordinador> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Coordinador>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Coordinador getRegistroPorId(int id)
        {
            Coordinador registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("id=@id");
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                var conexion = Connection.getConnection();
                registro = conexion.QueryFirstOrDefault<Coordinador>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
