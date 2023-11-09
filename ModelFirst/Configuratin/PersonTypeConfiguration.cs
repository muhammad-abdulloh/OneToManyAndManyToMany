using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelFirst.Models;

namespace ModelFirst.Configuratin
{
    public class PersonTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {

            builder.Property(x => x.Name)
                .IsRequired();

            builder.HasMany(x => x.PersonCars)
                .WithOne(x => x.Persons)
                .HasForeignKey(x => x.PersonRustamId)
                .OnDelete(DeleteBehavior.SetNull);

            // agar biz qo'lda PersonCars kabi table yaratvomasak many to many qanday bo'ladi
            /*
            builder.HasMany(x => x.Cars)
                .WithOne(x => x.Persons)
                .HasForeignKey(x => x.PersonRustamId)
                .OnDelete(DeleteBehavior.SetNull);
            */
        }
    }
}
