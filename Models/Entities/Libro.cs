using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb24AM_NET._7.Entities
{
    public class Libro
    {
        [Key]

        [Required]
        public int PkLibro {  get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string Image { get; set; }
        
    }
}
