using System.ComponentModel.DataAnnotations;

namespace Persona.Shared
{
    public class Persona
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(maximumLength:100, ErrorMessage = "El nombre no puede tener mas que 100 caracteres")]
        public string Nombres { get; set; }
        [Required]
        [StringLength(maximumLength:100, ErrorMessage = "El Apellido no puede ter tener max 100 caracteres")]
        public string Apellidos { get; set; }
        [Required]
        [StringLength(maximumLength:13 , ErrorMessage = "La cedula debe contener 11 caracteres numericos")]
        public string Cedula { get; set; }
    }
}