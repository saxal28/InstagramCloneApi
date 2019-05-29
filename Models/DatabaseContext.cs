using Microsoft.EntityFrameworkCore;

namespace InstagramAPIClone.Models
{
    public class DatabaseContext: DbContext
    {
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .Property(post => post.Title)
                .IsRequired();
        }

        public virtual DbSet<Post> Post { get; set; }
    }
}