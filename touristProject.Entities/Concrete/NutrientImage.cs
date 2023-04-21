using touristProject.Core.Entities.Abstract;

namespace touristProject.Entities.Concrete
{
    public class NutrientImage : BaseEntity
    {
        public string ImageUrl { get; set; }
        public int NutrientId { get; set; }


        public Nutrient Nutrient { get; set; }
    }
}
