using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Mapping
{
    public class NutrientFavoriteMap : IEntityTypeConfiguration<NutrientFavorite>
    {
        public void Configure(EntityTypeBuilder<NutrientFavorite> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.UserId).IsRequired();
            builder.Property(n => n.NutrientId).IsRequired();
            builder.ToTable("NutrientFavorities");
        }
    }
}
