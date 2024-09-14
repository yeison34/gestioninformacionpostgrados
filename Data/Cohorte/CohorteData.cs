using Dapper;
using Data.Models;
using Data.Utilidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.PersonaModel
{
    public static class CohorteData
    {
        public static string SelectTabla()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT cohorte.id, cohorte.nombre, cohorte.fecha_resolucion,cohorte.fecha_finalizacion,cohorte.numero_estudiantes,cohorte.esactiva FROM cohorte");
            return sql.ToString();
        }
        public static List<Cohorte> GetCohortes()
        {
            List<Cohorte> cohortes = null;
            try
            {
                string sql = SelectTabla();
                var conexion = Connection.getConnection();
                cohortes = conexion.Query<Cohorte>(sql).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cohortes: " + ex.Message);
            }

            return cohortes;
        }


        public static Cohorte CrearCohorte(Cohorte cohorte)
        {
           try
            {
                string sql = "INSERT INTO cohorte(id,nombre,fecha_resolucion,fecha_finalizacion,numero_estudiantes,esactiva) values (@id,@nombre, @fecha_resolucion, @fecha_finalizacion,@numero_estudiantes,@esactiva)";
                var conexion = Connection.getConnection();
                int id = conexion.ExecuteScalar<int>("select nextval('cohorte_id_seq'::regclass)");
                cohorte.Id = id;
                conexion.Execute(sql,cohorte);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la cohorte: " + ex.Message);
            }
            return cohorte;
        }
        //public static void ActualizarCohorte(Cohorte cohorte)
        //{
        //    string sql = $"UPDATE {Cohorte.NombreTabla} SET " +
        //                 $"{Cohorte.NombreCampoNombre} = @Nombre, " +
        //                 $"{Cohorte.NombreCampoFechaResolucion} = @FechaResolucion, " +
        //                 $"{Cohorte.NombreCampoFechaFinalizacion} = @FechaFinalizacion, " +
        //                 $"{Cohorte.NombreCampoNumeroEstudiantes} = @NumeroEstudiantes, " +
        //                 $"{Cohorte.NombreCampoEsActiva} = @EsActiva " +
        //                 $"WHERE {Cohorte.NombreCampoCodigo} = @Codigo";

        //    try
        //    {
        //        using (NpgsqlConnection conn = Connection.getConnection())
        //        {
        //            conn.Open();
        //            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
        //            {
        //                cmd.Parameters.AddWithValue("Nombre", cohorte.Nombre);
        //                cmd.Parameters.AddWithValue("FechaResolucion", cohorte.FechaResolucion);
        //                cmd.Parameters.AddWithValue("FechaFinalizacion", (object)cohorte.FechaFinalizacion ?? DBNull.Value);
        //                cmd.Parameters.AddWithValue("NumeroEstudiantes", (object)cohorte.NumeroEstudiantes ?? DBNull.Value);
        //                cmd.Parameters.AddWithValue("EsActiva", cohorte.EsActiva);
        //                cmd.Parameters.AddWithValue("Codigo", cohorte.Codigo);

        //                cmd.ExecuteNonQuery();
        //            }
        //            conn.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al actualizar la cohorte: " + ex.Message);
        //    }
        //}
    }

}

