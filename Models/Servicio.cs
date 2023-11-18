using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace RostrosFelices.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string NombreServicio { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreEmpleado { get; set; }
        public string Observacion { get; set; }
        public Cliente Cliente { get; set; }
    }
}
