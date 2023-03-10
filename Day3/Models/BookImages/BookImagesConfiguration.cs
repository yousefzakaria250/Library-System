using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day3.Models
{
    public class BookImagesConfiguration : IEntityTypeConfiguration<BookImages>
    {
        public void Configure(EntityTypeBuilder<BookImages> builder)
        {
            builder.HasKey(k => k.ID);
            builder.Property(p => p.ID)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(p=>p.Path)
                .IsRequired()
                .HasMaxLength(900);


        }
    }
}
