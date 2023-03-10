using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day3.Models
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {

            builder.ToTable("Author");
            builder.HasKey(k => k.ID);
            builder.Property(p=>p.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(p=>p.Author_Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
