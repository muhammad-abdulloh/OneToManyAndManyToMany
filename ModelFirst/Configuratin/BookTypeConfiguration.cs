using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelFirst.Models;

namespace ModelFirst.Configuratin
{
    public class BookTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .HasDefaultValue("Unknown")
                .IsRequired();

            builder.HasOne(x => x.Printers)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.Id)
                .OnDelete(DeleteBehavior.Cascade); // bironta company o'chsa shunga bog'liq hama userlaram o'chib ketadi
                
        }
    }
}
