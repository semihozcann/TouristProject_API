using touristProject.Core.Entities.Abstract;

namespace touristProject.Entities.Concrete
{
    public class Nutrient : BaseEntity, IEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public string Ingredients { get; set; }
        public string ImageUrl { get; set; }

        public virtual Category Category { get; set; }
        public List<NutrientComment> NutrientComments { get; set; }
        public List<NutrientImage> NutrientImages { get; set; }
    }
}
