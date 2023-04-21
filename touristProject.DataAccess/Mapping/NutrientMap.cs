using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Mapping
{
    public class NutrientMap : IEntityTypeConfiguration<Nutrient>
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.CategoryId).IsRequired();
            builder.Property(n => n.Name).IsRequired();
            builder.Property(n => n.Name).HasMaxLength(50);
            builder.Property(n => n.Description).IsRequired();
            builder.Property(n => n.Description).HasMaxLength(1500);
            builder.Property(n => n.SmallDescription).IsRequired();
            builder.Property(n => n.SmallDescription).HasMaxLength(100);
            builder.Property(n => n.Ingredients).IsRequired();
            builder.Property(n => n.Ingredients).HasMaxLength(1500);
            builder.Property(n => n.ImageUrl);
            builder.ToTable("Nutrients");


        }
    }
}
