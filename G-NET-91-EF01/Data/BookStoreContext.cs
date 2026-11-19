using G_NET_91_EF01.Models;
using Microsoft.EntityFrameworkCore;

namespace G_NET_91_EF01.Data
{
    internal class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ARTE257;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}