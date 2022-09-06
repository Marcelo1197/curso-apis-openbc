using System.ComponentModel.DataAnnotations;

namespace api_ejercicio.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; }

        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; }

        [Required, StringLength(500)]
        public string DescripcionLarga { get; set; }

        public string PublicoObjetivo { get; set; }

        public string Objetivos { get; set; }

        public string Requisitos { get; set; }

        [Required]
        public int Nivel { get; set; }

    }
}
