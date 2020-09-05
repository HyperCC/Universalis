using System.ComponentModel.DataAnnotations;

namespace Universalis.Models
{
    /// <summary>
    /// Academic model of Universalis
    /// </summary>
    public class Academic
    {
        /// <summary>
        /// Academic id 
        /// </summary>
        /// <value></value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The complete Nombre
        /// </summary>
        /// <value></value>
        [Required]
        public string Nombre { get; set; }

        /// <summary>
        /// The Cargo
        /// </summary>
        /// <value></value>
        [Required]
        public string Cargo { get; set; }

        /// <summary>
        /// The Unidad in the university
        /// </summary>
        /// <value></value>
        [Required]
        public string Unidad { get; set; }

        /// <summary>
        /// The work E-mail 
        /// </summary>
        /// <value></value>
        public string Email { get; set; }

        /// <summary>
        /// The office Telefono
        /// </summary>
        /// <value></value>
        public string Telefono { get; set; }

        /// <summary>
        /// The work Oficina 
        /// </summary>
        /// <value></value>
        public string Oficina { get; set; }

        /// <summary>
        /// The work Direccion 
        /// </summary>
        /// <value></value>
        [Required]
        public string DireccionTrabajo { get; set; }
    }
}