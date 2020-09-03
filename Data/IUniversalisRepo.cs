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
        /// Standard query operators to Academic with methods that follow the LINQ pattern
        /// </summary>
        /// <returns>Enumerable Academics</returns>
        IEnumerable<Academic> GetAppAcademics();

        /// <summary>
        /// Get a Academic by an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Academic by id</returns>
        Academic GetAcademicById(int id);
    }
}