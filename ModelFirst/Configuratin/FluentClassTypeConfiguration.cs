using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelFirst.Models.External;

namespace ModelFirst.Configuratin
{
    public class FluentClassTypeConfiguration : IEntityTypeConfiguration<FluentClass>
    {
        public void Configure(EntityTypeBuilder<FluentClass> builder)
        {
            builder.HasQueryFilter(x => x.IsDeleted ==  false);
            builder.HasQueryFilter(x => x.Age > 18);

            builder.Property(x => x.Name)
                .IsRequired();
        }
    }
}
