using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Usuarios
{
    public partial class RolData
    {
        private static string selectTabla()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT usuarios_rol.id,usuarios_rol.nombre,usuarios_rol.esactivo");
            stringBuilder.Append(" FROM ");
            stringBuilder.Append("usuarios_rol");
            return stringBuilder.ToString();
        }

        public static List<Rol> getRegistros()
        {
            List<Rol> registros = null;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Rol>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }
        public static Rol getRegistroPorId(int id)
        {
            Rol registro = null;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(selectTabla());
                sql.Append(" WHERE ");
                sql.Append("usuarios_rol.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registro = conexion.QueryFirstOrDefault<Rol>(sql.ToString(), parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static Usuario insertarRegistro(Usuario usuario)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuarios_rol (id,nombre,esactivo) values(@id,@nombre,@esactivo)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('usuarios_rol_id_seq'::regclass)");
                usuario.Id = id;
                conexion.Execute(sql.ToString(), usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public static void actualizarRegistro(Rol rol)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE usuarios_rol set nombre=@nombre,esactivo=@esactivo");
                sql.Append(" WHERE id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(), rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
