using Microsoft.EntityFrameworkCore;
using Universalis.Models;

namespace Universalis.Data
{
    public class UniversalisContext : DbContext
    {
        public UniversalisContext(DbContextOptions<UniversalisContext> opt): base(opt)
        {
            
        }

        public DbSet<Academic> Academics { get; set; }

    }
}