using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.DataAccess.Concrete;
using touristProject.Core.Entities.Concrete;
using touristProject.DataAccess.Abstract;
using touristProject.DataAccess.Concrete.EntityFramework.Context;

namespace touristProject.DataAccess.Concrete.EntityFramework
{
    public class EfUserRepository : BaseEntityRepository<User>, IUserRepository
    {
        public EfUserRepository(DbContext context) : base(context)
        {
        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            using (var context = new TouristProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
