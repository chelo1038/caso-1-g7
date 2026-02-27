using System;

namespace Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Models
{
    public class Reservas
    {
        public int Id { get; set; }
        public string NombreDelAsociado { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaDelServicio { get; set; }
        public DateTime FechaDeRegistro { get; set; }

        public int IdServicio { get; set; }
        public Servicios Servicio { get; set; }
    }
}