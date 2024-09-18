using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Estudiante
{
    public partial class EstudianteData
    {
        public static string SelectTabla()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT estudiante_estudiante.id,estudiante_estudiante.codigo,estudiante_estudiante.idpersona,estudiante_estudiante.idprograma,estudiante_estudiante.fechavinculacion,estudiante_estudiante.esactivo,estudiante_estudiante.esvinculado,estudiante_estudiante.idprogramacursa,estudiante_estudiante.idsemestre,estudiante_estudiante.fechaingreso,estudiante_estudiante.fechaegreso,estudiante_estudiante.esgresado FROM estudiante_estudiante ");
            return sql.ToString();
        }

        public static Estudiante insertarRegistro(Estudiante registro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO estudiante_estudiante (id,codigo,idpersona,idprograma,fechavinculacion,esactivo,esvinculado,idprogramacursa,idsemestre,fechaingreso,fechaegreso,esgresado)");
                sql.Append(" VALUES (@id,@codigo,@idpersona,@idprograma,@fechavinculacion,@esactivo,@esvinculado,@idprogramacursa,@idsemestre,@fechaingreso,@fechaegreso,@esgresado)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('estudiante_estudiante_id_seq'::regclass)");
                registro.Id = id;
                conexion.Execute(sql.ToString(), registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static void actualizarRegistro(Estudiante registro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE estudiante_estudiante ");
                sql.Append("set id=@id,codigo=@codigo, idpersona=@idpersona, idprograma=@idprograma, fechavinculacion=@fechavinculacion, esactivo=@esactivo, esvinculado=@esvinculado,idprogramacursa=@idprogramacursa,idsemestre=@idsemestre,fechaingreso=@fechaingreso,fechaegreso=@fechaegreso,esgresado=@esgresado");
                sql.Append(" WHERE id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(), registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Estudiante> getRegistros()
        {
            List<Estudiante> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Estudiante>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Estudiante getRegistroPorId(int id)
        {
            Estudiante registro = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("id=@id");
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                var conexion = Connection.getConnection();
                registro = conexion.QueryFirstOrDefault<Estudiante>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
