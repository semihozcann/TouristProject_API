using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.DataAccess.Abstract;
using touristProject.Entities.Concrete;

namespace touristProject.DataAccess.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
    }


}
