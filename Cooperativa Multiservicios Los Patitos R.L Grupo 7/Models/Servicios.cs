using System.ComponentModel.DataAnnotations;

namespace Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models
{
        public class Servicio
        {
            [Key]
            public int Id { get; set; }   // PK, Identity, Not Null

            [Required(ErrorMessage = "El nombre es obligatorio")]
            [StringLength(100)]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "La descripción es obligatoria")]
            [StringLength(200)]
            public string Descripcion { get; set; }

            [Required(ErrorMessage = "El monto es obligatorio")]
            [Range(0.01, 999999999)]
            public decimal Monto { get; set; }

            [Required(ErrorMessage = "El IVA es obligatorio")]
            [Range(0.01, 1)]
            public decimal IVA { get; set; }

            [Required(ErrorMessage = "El área de servicio es obligatoria")]
            [Range(1, 3)]
            public int AreaServicio { get; set; }
            /*
             1 – Servicios Financieros
             2 – Servicios de Salud
             3 – Servicios de Capacitación
            */

            [Required(ErrorMessage = "El encargado es obligatorio")]
            [StringLength(200)]
            public string Encargado { get; set; }

            [Required(ErrorMessage = "La sucursal es obligatoria")]
            [StringLength(100)]
            public string Sucursal { get; set; }

            [Required]
            public DateTime FechaDeRegistro { get; set; }

            public DateTime? FechaDeModificacion { get; set; }

            [Required]
            public bool Estado { get; set; } // 1 Activo | 0 Inactivo
        }
    }


