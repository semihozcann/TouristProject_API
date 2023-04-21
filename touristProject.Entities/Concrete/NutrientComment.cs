using touristProject.Core.Entities.Abstract;
using touristProject.Core.Entities.Concrete;

namespace touristProject.Entities.Concrete
{
    public class NutrientComment : BaseEntity
    {
        public int UserId { get; set; }
        public int NutrientId { get; set; }
        public string Comment { get; set; }
        public double Point { get; set; }


        //Navigation Property
        public virtual User User { get; set; }
        public virtual Nutrient Nutrient { get; set; }
    }
}
