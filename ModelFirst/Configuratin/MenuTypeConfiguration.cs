using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelFirst.Models;
using ModelFirst.Models.MyModels;

namespace ModelFirst.Configuratin
{
    public class MenuTypeConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .HasDefaultValue("Unknown")
                .IsRequired();

            builder.HasOne(x => x.Parent)
                .WithMany(x => x.Children)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.Cascade); // bironta company o'chsa shunga bog'liq hama userlaram o'chib ketadi
                
        }
    }
}
