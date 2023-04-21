using Microsoft.EntityFrameworkCore;
using touristProject.Core.DataAccess.Concrete;
using touristProject.DataAccess.Abstract;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Concrete.EntityFramework
{
    public class EfNutrientRepository : BaseEntityRepository<Nutrient>, INutrientRepository
    {
        public EfNutrientRepository(DbContext context) : base(context)
        {
        }
    }
}
