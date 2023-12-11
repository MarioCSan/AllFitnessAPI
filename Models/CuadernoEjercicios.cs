using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllFitnessAPI.Models
{
    public class CuadernoEjercicios
    {
        [Key]
        public int Id { get; set; }

        public int IdUsuario { get; set; }
        
        public int IdEjercicio { get; set; }
        
        public int IdRutina { get; set; }
        
      
        public int Repeticiones { get; set; }

        
        public int Series { get; set; }
        
        public int Peso { get; set; }
       
    }
}
    