using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(50);

            builder.ToTable("Categories");

            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Yiyecek"
                },
                new Category
                {
                    Id = 2,
                    Name = "İçecek"
                },
                new Category
                {
                    Id = 3,
                    Name = "Tatlı"
                }
                );
        }
    }
}
