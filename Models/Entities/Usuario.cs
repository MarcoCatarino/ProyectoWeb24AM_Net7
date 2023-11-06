using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoWeb24AM_NET._7.Entities
{
    public class Usuario
    {
        [Key]

        [Required]
        public int PKUsuario {  get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido  { get; set;}
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        [ForeignKey("Roles")]
        public int FkRol {  get; set; }
        public Rol Roles {  get; set; }
    }
}
