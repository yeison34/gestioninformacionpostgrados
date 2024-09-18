using System;

namespace Data.Cohorte
{
    public partial class Cohorte
    {
        public static string NombreTabla = "cohorte_cohorte";
        public static string NombreCampoId = "cohorte_cohorte.id";
        public static string NombreCampoNombre = "cohorte_cohorte.nombre";       
        public static string NombreCampoFechaResolucion = "cohorte_cohorte.fecharesolucion";
        public static string NombreCampoFechaFinalizacion = "cohorte_cohorte.fechafinalizacion";
        public static string NombreCampoNumeroEstudiantes = "cohorte_cohorte.numeroestudiantes";
        public static string NombreCampoEsActiva = "cohorte_cohorte.esactiva";


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
