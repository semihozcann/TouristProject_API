using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Mapping
{
    public class NutrientImageMap : IEntityTypeConfiguration<NutrientImage>
    {
        public void Configure(EntityTypeBuilder<NutrientImage> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.ImageUrl).IsRequired();
            builder.Property(n => n.NutrientId).IsRequired();
            builder.ToTable("NutrientImages");
        }
    }
}
