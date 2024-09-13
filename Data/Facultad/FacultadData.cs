using Dapper;
using Data.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Facultad
{
    public partial class FacultadData
    {
        public static string SelectTabla()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select facultad_facultad.id, facultad_facultad.codigo, facultad_facultad.nombre, facultad_facultad.esactivo from facultad_facultad");
            return sb.ToString();
        }
        public static List<Facultad> getRegistros() {
            List<Facultad> registros = null;
            try
            {
                StringBuilder reg = new StringBuilder();
                reg.Append(SelectTabla());
                var conexion = Connection.getConnection();

                registros = conexion.Query<Facultad>(reg.ToString()).ToList();
            }
            catch (Exception e) {
                throw e;
            }
            return registros;
        }


        public static Facultad getRegistroPorId(int id)
        {
            Facultad registros = null;
            try
            {
                StringBuilder reg = new StringBuilder();
                reg.Append(SelectTabla());
                reg.Append(" where facultad_facultad.id = @id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters(); 
                parametros.Add("id",id);
                registros = conexion.Query<Facultad>(reg.ToString(), parametros).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }
            return registros;
        }


    }
}
