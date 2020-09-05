using System.Collections.Generic;
using Universalis.Models;
using System.Linq;

namespace Universalis.Data
{
    public class SqlUniversalisRepo : IUniversalisRepo
    {
        private readonly UniversalisContext _context;
        public SqlUniversalisRepo(UniversalisContext context)
        {
            this._context = context;
        }
        public Academic GetAcademicById(int id)
        {
            return this._context.Academics.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Academic> GetAllAcademics()
        {
            return this._context.Academics.ToList();
        }
    }
}