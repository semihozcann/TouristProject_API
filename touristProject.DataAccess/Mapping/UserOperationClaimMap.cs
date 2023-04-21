using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using touristProject.Entities.Concrete;
using touristProject.Core.Entities.Concrete;

namespace touristProject.DataAccess.Mapping
{
    public class UserOperationClaimMap : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.UserId);
            builder.Property(u => u.OperationClaimId);
            builder.Property(u => u.CreatedDate);
            builder.Property(u => u.UpdatedDate);
            builder.ToTable("UserOperationClaims");
        }
    }
}
