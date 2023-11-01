using System.ComponentModel.DataAnnotations;

namespace AllFitnessAPI.Models
{
    public class Usuarios
    {
        [Key]
        public int idUsuario {get; set;}

        public string nombre { get; set; }
        public string email { get; set; }
        public string nombreUsuario { get; set; }
        public string imagenUsuario { get; set; }
        public string password { get; set; }

    }
}
