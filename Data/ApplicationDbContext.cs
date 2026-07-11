using EntityFramworkExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace EntityFramworkExample.Data; 

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ETFpractice;Trusted_Connection=True;TrustServerCertificate=True");
    //}
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Author { get; set; }
}
