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
    public class NutrientCommentMap : IEntityTypeConfiguration<NutrientComment>
    {
        public void Configure(EntityTypeBuilder<NutrientComment> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.UserId).IsRequired();
            builder.Property(n => n.NutrientId).IsRequired();
            builder.Property(n => n.Comment).IsRequired();
            builder.Property(n => n.Comment).HasMaxLength(2000);
            builder.Property(n => n.Point).IsRequired();
            builder.Property(n => n.Point).IsRequired();
            builder.ToTable("NutrientComments");
        }
    }
}
