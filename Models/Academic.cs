
namespace Universalis.Models
{
    /// <summary>
    /// Enumerator to Sexo
    /// </summary>
    public enum Sexo
    {
        VAR = 0,
        MUJ = 1
    }

    /// <summary>
    /// Academic model of Universalis
    /// </summary>
    public class Academic
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
        /// The Rut
        /// </summary>
        /// <value></value>
        public string Rut { get; set; }

        /// <summary>
        /// The Sexo enum: { VAR, MUJ }
        /// </summary>
        /// <value></value>
        public int Sexo { get; set; }

        /// <summary>
        /// The Cargo
        /// </summary>
        /// <value></value>
        public int Cargo { get; set; }

        /// <summary>
        /// The Unidad in the university
        /// </summary>
        /// <value></value>
        public int Unidad { get; set; }

        /// <summary>
        /// The work E-mail 
        /// </summary>
        /// <value></value>
        public int Email { get; set; }

        /// <summary>
        /// The mobile Telefono
        /// </summary>
        /// <value></value>
        public int Telefono { get; set; }

        /// <summary>
        /// The work Oficina 
        /// </summary>
        /// <value></value>
        public int Oficina { get; set; }

        /// <summary>
        /// The work Direccion 
        /// </summary>
        /// <value></value>
        public int DireccionTrabajo { get; set; }

        /// <summary>
        /// The home Direccion
        /// </summary>
        /// <value></value>
        public int DireccionCasa { get; set; }

        /// <summary>
        /// The residential Comuna
        /// </summary>
        /// <value></value>
        public int Comuna { get; set; }

    }
}