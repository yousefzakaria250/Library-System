using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day3.Models
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .HasColumnName("Title")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p=>p.Description)
                .HasMaxLength(500)
                .HasColumnName("Description")
                .IsRequired();


            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();


          
            


        }
    }
}
