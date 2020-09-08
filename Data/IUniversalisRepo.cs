using System.Collections.Generic;
using Universalis.Models;

namespace Universalis.Data
{
    /// <summary>
    /// Principal interface to give EndPoints to client
    /// </summary>
    public interface IUniversalisRepo
    {
        /// <summary>
        /// Save the changes in the DB
        /// </summary>
        /// <returns></returns>
        bool SaveChanges(); 

        /// <summary>
        /// Standard query operators to Academic with methods that follow the LINQ pattern
        /// </summary>
        /// <returns>Enumerable Academics</returns>
        IEnumerable<Academic> GetAllAcademics();

        /// <summary>
        /// Get a Academic by an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Academic by id</returns>
        Academic GetAcademicById(int id);

        /// <summary>
        /// Create a new Academic
        /// </summary>
        /// <param name="academic"></param>
        void CreateAcademic(Academic academic);
    }
}