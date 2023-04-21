using touristProject.Core.Entities.Abstract;
using touristProject.Core.Entities.Concrete;

namespace touristProject.Entities.Concrete
{
    public class NutrientFavorite : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int NutrientId { get; set; }

        public virtual User User { get; set; }
        public virtual Nutrient Nutrient { get; set; }
    }
}
