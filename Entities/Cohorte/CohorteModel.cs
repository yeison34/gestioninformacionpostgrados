using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Cohorte
{
    public class CohorteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public int NumeroEstudiantes { get; set; }
        public bool EsActiva { get; set; }

        public CohorteModel() { }
        public CohorteModel(int id, string nombre, DateTime? fechaResolucion, DateTime? fechaFinalizacion, int numeroEstudiantes, bool esActiva)
        {
            Id = id;
            Nombre = nombre;
            FechaResolucion = fechaResolucion;
            FechaFinalizacion = fechaFinalizacion;
            NumeroEstudiantes = numeroEstudiantes;

        }
    }
}
