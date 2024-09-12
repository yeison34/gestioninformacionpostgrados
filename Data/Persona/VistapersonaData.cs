using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Persona
{
    public partial class VistapersonaData
    {
        public static string SelectTabla()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT persona_vistapersona.id,persona_vistapersona.idtipoidentificacion,persona_vistapersona.cedula,persona_vistapersona.nombres,persona_vistapersona.apellidos,persona_vistapersona.idgenero,persona_vistapersona.fechanacimiento,persona_vistapersona.idpais,persona_vistapersona.iddepartamento,persona_vistapersona.idciudad,persona_vistapersona.correo,persona_vistapersona.telefono,persona_vistapersona.idusuario,persona_vistapersona.genero,persona_vistapersona.tipoidentificacion,persona_vistapersona.pais,persona_vistapersona.departamento,persona_vistapersona.ciudad FROM persona_vistapersona");
            return sql.ToString();
        }
        public static List<Vistapersona> getRegistros()
        {
            List<Vistapersona> registros = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                var conexion = Connection.getConnection();
                registros = conexion.Query<Vistapersona>(sql.ToString()).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return registros;
        }
    }
}
