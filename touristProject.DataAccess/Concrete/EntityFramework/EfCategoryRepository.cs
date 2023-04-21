using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.DataAccess.Concrete;
using touristProject.DataAccess.Abstract;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryRepository : BaseEntityRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
