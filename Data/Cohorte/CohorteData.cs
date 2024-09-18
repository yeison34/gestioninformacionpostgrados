using Dapper;
using Data.Utilidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Cohorte
{
    public partial class CohorteData
    {
        public static string SelectTabla()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT cohorte_cohorte.id, cohorte_cohorte.nombre, cohorte_cohorte.fecharesolucion,cohorte_cohorte.fechafinalizacion,cohorte_cohorte.numeroestudiantes,cohorte_cohorte.esactiva FROM cohorte_cohorte");
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
                string sql = "INSERT INTO cohorte_cohorte(id,nombre,fecharesolucion,fechafinalizacion,numeroestudiantes,esactiva) values (@id,@nombre, @fecharesolucion, @fechafinalizacion,@numeroestudiantes,@esactiva)";
                var conexion = Connection.getConnection();
                int id = conexion.ExecuteScalar<int>("select nextval('cohorte_cohorte_id_seq'::regclass)");
                cohorte.Id = id;
                conexion.Execute(sql,cohorte);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la cohorte: " + ex.Message);
            }
            return cohorte;
        }

        public static Cohorte getRegistroPorId(int id)
        {
            Cohorte cohortes = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(SelectTabla());
                sql.Append(" WHERE cohorte_cohorte.id=@id");
                var conexion = Connection.getConnection();
                DynamicParameters parametros = new DynamicParameters();
                parametros.Add("id",id);
                cohortes = conexion.Query<Cohorte>(sql.ToString(),parametros).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cohortes: " + ex.Message);
            }

            return cohortes;
        }

        public static void actualizarRegistro(Cohorte cohorte)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE cohorte_cohorte set nombre=@nombre,fecharesolucion=@fecharesolucion,fechafinalizacion=@fechafinalizacion,numeroestudiantes=@numeroestudiantes,esactiva=@esactiva");
                sql.Append(" WHERE id=@id");
                var conexion = Connection.getConnection();
                conexion.Execute(sql.ToString(), cohorte);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la cohorte: " + ex.Message);
            }
        }

    }

}

