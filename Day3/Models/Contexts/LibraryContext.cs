using Microsoft.EntityFrameworkCore;

namespace Day3.Models.Contexts
{
    public class LibraryContext :DbContext
    {
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImages> BookImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = . ; Initial Catalog = LibraryDB ; Integrated Security = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookImagesConfiguration());
           modelBuilder.RelationsMapping();
        }
    }
}
