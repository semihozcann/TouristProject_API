using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using touristProject.Core.Entities.Concrete;

namespace touristProject.DataAccess.Mapping
{
    public class OperationClaimMap : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id).ValueGeneratedOnAdd();
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.Name).HasMaxLength(50);
            builder.Property(o => o.CreatedDate);
            builder.Property(o => o.UpdatedDate);
            builder.ToTable("OperationClaims");
        }
    }
}
