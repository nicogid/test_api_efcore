using Microsoft.EntityFrameworkCore;

namespace TestApi.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItem{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.Property(e => e.Id).HasComputedColumnSql("id");
                entity.Property(e => e.Name).HasComputedColumnSql("name");
                entity.Property(e => e.IsComplete).HasComputedColumnSql("is_complete");

            });
        }
    }
}