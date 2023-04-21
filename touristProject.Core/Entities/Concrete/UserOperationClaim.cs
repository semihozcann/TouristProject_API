using touristProject.Core.Entities.Abstract;

namespace touristProject.Core.Entities.Concrete
{
    public class UserOperationClaim : BaseEntity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
