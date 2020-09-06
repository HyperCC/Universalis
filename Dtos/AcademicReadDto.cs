
namespace Universalis.Dtos
{
    /// <summary>
    /// Academic DTO model from Universalis API
    /// </summary>
    public class AcademicReadDto
    {
        /// <summary>
        /// Academic id 
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// The complete Nombre
        /// </summary>
        /// <value></value>
        public string Nombre { get; set; }

        /// <summary>
        /// The Cargo
        /// </summary>
        /// <value></value>
        public string Cargo { get; set; }

        /// <summary>
        /// The Unidad in the university
        /// </summary>
        /// <value></value>
        public string Unidad { get; set; }

        /// <summary>
        /// The work E-mail 
        /// </summary>
        /// <value></value>
        public string Email { get; set; }

        // the Telefono is not necessary show it to the client

        /// <summary>
        /// The work Oficina 
        /// </summary>
        /// <value></value>
        public string Oficina { get; set; }

        /// <summary>
        /// The work Direccion 
        /// </summary>
        /// <value></value>
        public string DireccionTrabajo { get; set; }
    }
}