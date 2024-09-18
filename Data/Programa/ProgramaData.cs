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
            sb.Append("select programa_programa.id, programa_programa.codigo, programa_programa.nombre,programa_programa.idfacultad,programa_programa.correo,programa_programa.descripcion," +
                "programa_programa.lineastrabajo,programa_programa.fecha,programa_programa.numerores,programa_programa.archivores,programa_programa.logo,programa_programa.espregrado," +
                "programa_programa.espostgrado, programa_programa.esactivo from programa_programa WHERE esactivo = True");
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
                reg.Append(" AND programa_programa.id = @id");
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

        public static Response insertarRegistro(Programa programa)
        {
            string msn = string.Empty;
            string icono = "success";
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO programa_programa (id,codigo,nombre,idfacultad,correo,descripcion,lineastrabajo,fecha,numerores,archivores,logo,espregrado,espostgrado,esactivo) values(@id,@codigo,@nombre,@idfacultad,@correo,@descripcion,@lineastrabajo,@fecha,@numerores,@archivores,@logo,@espregrado,@espostgrado,@esactivo)");
                var conexion = Connection.getConnection();
                var id = conexion.ExecuteScalar<int>("SELECT nextval('programa_programa_id_seq'::regclass)");
                programa.Id = id;
                conexion.Execute(sql.ToString(), programa);
                msn = "Registro Insertado";
            }
            catch (Exception)
            {
                msn = "Registro No Insertado";
                icono = "error";
            }
            Response response = new Response(true, msn, icono);
            return response;
        }

        public static Response actualizarRegistro(Programa registro)
        {
            string msn = string.Empty;
            string icono = "success";
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE programa_programa ");
                sql.Append("set id=@id, codigo=@codigo, nombre=@nombre, idfacultad=@idfacultad,correo=@correo, descripcion=@descripcion, lineastrabajo=@lineastrabajo, fecha=@fecha, numerores=@numerores, archivores=@archivores, logo=@logo, espregrado=@espregrado, espostgrado=@espostgrado, esactivo=@esactivo");
                sql.Append(" WHERE id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(), registro);
                msn = "Registro Actualizado";
            }
            catch (Exception)
            {

            }
            Response response = new Response(true, msn, icono);
            return response;
        }

        public static Response EliminarRegistro(int id)
        {
            string msn = string.Empty;
            string icono = "success";
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE programa_programa ");
                sql.Append("set esactivo=False");
                sql.Append(" WHERE id="+id.ToString() );
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString());
                msn = "Registro Eliminado";
            }
            catch (Exception )
            {
                //throw ex;
                msn = "Registro no eliminado";
                icono = "error";
            }
            Response response = new Response(true, msn,icono );
            return response;
        }
    }
}
