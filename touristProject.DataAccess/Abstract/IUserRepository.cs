using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.DataAccess.Abstract;
using touristProject.Core.Entities.Concrete;

namespace touristProject.DataAccess.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
        Task<List<OperationClaim>> GetClaims(User user);
    }
}
