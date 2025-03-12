using Microsoft.EntityFrameworkCore;
using News.Models;

namespace News.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //definiamo le tabelle
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        //metodo per usare la Fluent API, gestire esplicitamente le relazioni e aggiungere constraint che non sarebbe possibile aggiunger con i Data Attributes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Esplicitiamo la relazione tra le entità tramite Fluent API
            modelBuilder.Entity<Post>().HasOne(b => b.Blog).WithMany(p => p.Posts);

            //imposto il constraint DEFAULT sulla colonna PublishDate
            modelBuilder.Entity<Post>().Property(p => p.PublishDate).HasDefaultValueSql("GETDATE()");
        }
    }
}
