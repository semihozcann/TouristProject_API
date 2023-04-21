using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.Entities.Concrete;

namespace touristProject.Business.Abstract
{
    public interface IUserService
    {

        Task<List<OperationClaim>> GetClaims(User user);
        Task AddAsync(User user);
        Task<User> GetByMail(string email);

    }
}
