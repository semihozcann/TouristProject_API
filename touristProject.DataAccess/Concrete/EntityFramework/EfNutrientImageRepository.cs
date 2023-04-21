using Microsoft.EntityFrameworkCore;
using touristProject.Core.DataAccess.Concrete;
using touristProject.DataAccess.Abstract;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Concrete.EntityFramework
{
    public class EfNutrientImageRepository : BaseEntityRepository<NutrientImage>, INutrientImageRepository
    {
        public EfNutrientImageRepository(DbContext context) : base(context)
        {
        }
    }
}
