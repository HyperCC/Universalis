using System;
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
        /// Save new changes from context
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            // if number of objects updateds >=0 return true
            return (_context.SaveChanges() >= 0);
        }

        /// <summary>
        /// All Academics from DB
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Academic> GetAllAcademics()
        {
            return this._context.Academics.ToList();
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
        /// Create a new Academic with parameter validate
        /// </summary>
        /// <param name="academic"></param>
        public void CreateAcademic(Academic academic)
        {
            if (academic == null)
            {
                throw new ArgumentNullException(nameof(academic));
            }

            _context.Academics.Add(academic);
        }

        /// <summary>
        /// Update a existent Academic provided by DB
        /// </summary>
        /// <param name="academic"></param>
        public void UpdateAcademic(Academic academic)
        {
            // still nothing
        }

        /// <summary>
        /// Delete a Academic verified
        /// </summary>
        /// <param name="academic"></param>
        public void DeleteAcademic(Academic academic)
        {
            if (academic == null)
            {
                throw new ArgumentNullException(nameof(academic));
            }

            _context.Academics.Remove(academic);
        }
    }
}