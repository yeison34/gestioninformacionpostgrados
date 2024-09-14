using System;
using System.ComponentModel.DataAnnotations;

namespace PostgradosGestionInformacion.Models
{
    public class CohorteModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? FechaResolucion { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaFinalizacion { get; set; }

        [Range(0, int.MaxValue)]
        public int NumeroEstudiantes { get; set; }
    
        public bool EsActiva { get; set; }
        public CohorteModel()
        {
        }

        public CohorteModel(int id, string nombre, DateTime? fechaResolucion, DateTime? fechaFinalizacion, int numeroEstudiantes, bool esActiva)
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
