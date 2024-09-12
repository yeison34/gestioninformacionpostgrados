using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class PersonaData
    {
        public static string SelectTabla() { 
            StringBuilder sql=new StringBuilder();
            sql.Append("SELECT persona_persona.id,persona_persona.idtipoidentificacion,persona_persona.cedula,persona_persona.nombres,persona_persona.apellidos,persona_persona.idgenero,persona_persona.fechanacimiento,persona_persona.idpais,persona_persona.iddepartamento,persona_persona.idciudad,persona_persona.correo,persona_persona.telefono,persona_persona.idusuario FROM persona_persona");
            return sql.ToString();
        }

        public static Persona insertarRegistro(Persona registro)
        {
            try { 
                StringBuilder sql=new StringBuilder();
                sql.Append("INSERT INTO persona_persona (id,idtipoidentificacion,cedula,nombres,apellidos,idgenero,fechanacimiento,idpais,iddepartamento,idciudad,correo,telefono,idusuario)");
                sql.Append(" VALUES (@id,@idtipoidentificacion,@cedula,@nombres,@apellidos,@idgenero,@fechanacimiento,@idpais,@iddepartamento,@idciudad,@correo,@telefono,@idusuario)");
                var conexion = Connection.getConnection();
                var id=conexion.ExecuteScalar<int>("SELECT nextval('persona_persona_id_seq'::regclass)");
                registro.Id = id;
                conexion.Execute(sql.ToString(),registro);
            }catch(Exception ex)
            {
                throw ex;
            }
            return registro;
        }

        public static void actualizarRegistro(Persona registro) {
            try{
                StringBuilder sql=new StringBuilder();
                sql.Append("UPDATE persona_persona ");
                sql.Append("set idtipoidentificacion=@idtipoidentificacion, cedula=@cedula, nombres=@nombres, apellidos=@apellidos, idgenero=@idgenero, fechanacimiento=@fechanacimiento, idpais=@idpais, iddepartamento=@iddepartamento, idciudad=@idciudad, correo=@correo, telefono=@telefono, idusuario=@idusuario");
                sql.Append(" WHERE id=@id");
                var conexion=Connection.getConnection();
                conexion.Execute(sql.ToString(),registro);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Persona> getRegistros()
        {
            List<Persona> registros = null;
            try {
                StringBuilder sql=new StringBuilder();
                sql.Append(SelectTabla());
                var conexion=Connection.getConnection();
                registros=conexion.Query<Persona>(sql.ToString()).ToList();
            }catch(Exception ex)
            {
                throw ex;
            }
            return registros;
        }

        public static Persona getRegistroPorId(int id)
        {
            Persona registro = null;
            try { 
                StringBuilder sql= new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE ");
                sql.Append("id=@id");
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                var conexion=Connection.getConnection();
                registro=conexion.QueryFirstOrDefault<Persona>(sql.ToString(),parametros);
            }catch(Exception ex)
            {
                throw ex;
            }
            return registro;
        }
    }
}
