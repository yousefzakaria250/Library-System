
using Microsoft.EntityFrameworkCore;

namespace Day3.Models
{
    public static class RelationshipsMapping
    {

        public static void RelationsMapping(this ModelBuilder builder)
        {
            builder.Entity<Author>()
                .HasMany(m => m.Books)
                .WithOne(o => o.Author)
                .HasForeignKey(a => a.Author_Id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<BookImages>()
                 .HasOne(o => o.Book)
                 .WithMany(m => m.BookImages)
                 .HasForeignKey(f => f.BookId)
                 .IsRequired()
                 .OnDelete(DeleteBehavior.Cascade);       

        }

    }
}
