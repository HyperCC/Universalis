using System.Collections.Generic;
using Universalis.Models;
using System.Linq;

namespace Universalis.Data
{
    /// <summary>
    /// Sql Server database connection
    /// </summary>
    public class SqlUniversalisRepo : IUniversalisRepo
    {

        /// <summary>
        /// The context
        /// </summary>
        private readonly UniversalisContext _context;

        /// <summary>
        /// The constructor with dependency injection
        /// </summary>
        /// <param name="context">the context</param>
        public SqlUniversalisRepo(UniversalisContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Find the first Academic by id
        /// </summary>
        /// <param name="id">id to search</param>
        /// <returns>Academic by id</returns>
        public Academic GetAcademicById(int id)
        {
            return this._context.Academics.FirstOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// All Academics from DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Academic> GetAllAcademics()
        {
            return this._context.Academics.ToList();
        }
    }
}