using System;

namespace Data.Models
{
    public class Cohorte
    {
        public static string NombreTabla = "cohorte";
        public static string NombreCampoId = "cohorte.id";
        public static string NombreCampoNombre = "cohorte.nombre";       
        public static string NombreCampoFechaResolucion = "cohorte.fecha_resolucion";
        public static string NombreCampoFechaFinalizacion = "cohorte.fecha_finalizacion";
        public static string NombreCampoNumeroEstudiantes = "cohorte.numero_estudiantes";
        public static string NombreCampoEsActiva = "cohorte.esactiva";


        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public int NumeroEstudiantes { get; set; }
        public bool EsActiva { get; set; }

        public Cohorte() { }
        public Cohorte(int id, string nombre, DateTime? fechaResolucion, DateTime? fechaFinalizacion, int numeroEstudiantes, bool esActiva)
        {
            Id = id;
            Nombre = nombre;
            FechaResolucion = fechaResolucion;
            FechaFinalizacion = fechaFinalizacion;
            NumeroEstudiantes = numeroEstudiantes;
            EsActiva = esActiva;
        }
    }
}
