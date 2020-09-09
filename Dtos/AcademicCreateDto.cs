using System.ComponentModel.DataAnnotations;

namespace Universalis.Dtos
{
    /// <summary>
    /// Academic DTO model to create action
    /// </summary>
    public class AcademicCreateDto
    {
        /// <summary>
        /// The complete Nombre
        /// </summary>
        /// <value></value>
        [Required]
        [MaxLength(63)]
        public string Nombre { get; set; }

        /// <summary>
        /// The Cargo
        /// </summary>
        /// <value></value>
        [Required]
        [MaxLength(63)]
        public string Cargo { get; set; }

        /// <summary>
        /// The Unidad in the university
        /// </summary>
        /// <value></value>
        [Required]
        [MaxLength(63)]
        public string Unidad { get; set; }

        /// <summary>
        /// The work E-mail 
        /// </summary>
        /// <value></value>
        [MaxLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// The office Telefono
        /// </summary>
        /// <value></value>
        [MaxLength(20)]
        public string Telefono { get; set; }

        /// <summary>
        /// The work Oficina 
        /// </summary>
        /// <value></value>
        [MaxLength(127)]
        public string Oficina { get; set; }

        /// <summary>
        /// The work Direccion 
        /// </summary>
        /// <value></value>
        [Required]
        [MaxLength(127)]
        public string DireccionTrabajo { get; set; }
    }
}