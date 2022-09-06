using System.ComponentModel.DataAnnotations;

namespace api_ejercicio.Models.DataModels
{
    public class User: BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required, EmailAddress]

        public string Email { get; set; } = string.Empty;

        [Required]

        public string Password { get; set; } = string.Empty;
    }
}
