using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllFitnessAPI.Models
{
    public class Usuario
    {
        [Key]
        [Column("IDUSUARIO")]
        public int idUsuario {get; set;}

        [Column("NOMBRE")]
        public String Nombre { get; set; }

        [Column("NombreUsuario")]
        public String NombreUsuario { get; set; }

        [Column("Email")]
        public String Email { get; set; }

        [Column("PerfilUsuario")]
        public String Perfil { get; set; }


        [Column("ImagenUsuario")]
        public String? ImagenUsuario { get; set; }

        [Column("PASSWORD")]
        public byte[] Password { get; set; }

        [Column("SALT")]
        public String Salt { get; set; }

    }
}
