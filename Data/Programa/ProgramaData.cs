using Dapper;
using Data.Usuarios;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Programa
{
    public partial class ProgramaData
    {
        public static string SelectTabla()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select programa_programa.id, programa_programa.codigo, programa_programa.nombre,programa_programa.idfacultad,programa_programa.espregrado,programa_programa.espostgrado, programa_programa.esactivo from programa_programa");
            return sb.ToString();
        }
        public static List<Programa> getRegistros()
        {
            List<Programa> registros = null;
            try
            {
                StringBuilder reg = new StringBuilder();
                reg.Append(SelectTabla());
                var conexion = Connection.getConnection();

                registros = conexion.Query<Programa>(reg.ToString()).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            return registros;
        }


        public static Programa getRegistroPorId(int id)
        {
            Programa registros = null;
            try
            {
                StringBuilder reg = new StringBuilder();
                reg.Append(SelectTabla());
                reg.Append(" where programa_programa.id = @id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id", id);
                registros = conexion.Query<Programa>(reg.ToString(), parametros).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }
            return registros;
        }

        public static Programa insertarRegistro(Programa usuario)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO programa_programa (id,codigo,nombre,idfacultad,espregrado,espostgrado,esactivo) values(@id,@codigo,@nombre,@idfacultad,@espregrado,@espostgrado,@esactivo)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('programa_programa_id_seq'::regclass)");
                usuario.Id = id;
                conexion.Execute(sql.ToString(), usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public static void actualizarRegistro(Programa registro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE programa_programa ");
                sql.Append("set id=@id, codigo=@codigo, nombre=@nombre, idfacultad=@idfacultad, espregrado=@espregrado, espostgrado=@espostgrado, esactivo=@esactivo");
                sql.Append(" WHERE id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(), registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
