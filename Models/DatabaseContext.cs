using Microsoft.EntityFrameworkCore;

namespace InstagramAPIClone.Models
{
    public class DatabaseContext: DbContext
    {
        
        public DatabaseContext()
        {}
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {}
        
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Blog> Post { get; set; }
    }
}