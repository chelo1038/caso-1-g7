using System.ComponentModel.DataAnnotations;

namespace Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Models
{
        public class Servicios
        {
        
            public int Id { get; set; }   // PK, Identity, Not Null

         
            public string Nombre { get; set; }

         
            public string Descripcion { get; set; }

            public decimal Monto { get; set; }

         
            public decimal IVA { get; set; }

          
            public int AreaServicio { get; set; }
           

       

            public string Encargado { get; set; }

         

            public string Sucursal { get; set; }

         

            public DateTime FechaDeRegistro { get; set; }

            public DateTime? FechaDeModificacion { get; set; }

            public bool Estado { get; set; } // 1 Activo | 0 Inactivo
        }
    }


