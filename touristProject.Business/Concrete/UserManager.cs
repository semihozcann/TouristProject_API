using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Business.Abstract;
using touristProject.Core.Entities.Concrete;
using touristProject.DataAccess.Abstract;

namespace touristProject.Business.Concrete
{
    public class UserManager : IUserService
    {

        #region Injection

        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion


        #region AddAsync

        public async Task AddAsync(User user)
        {
            await _userRepository.AddAsync(user);
            await _userRepository.SaveAsync();


        }

        #endregion

        #region GetByMail

        public async Task<User> GetByMail(string email)
        {
            return await _userRepository.GetAsync(u => u.Email == email);
        }

        #endregion

        #region GetClaims

        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            return await _userRepository.GetClaims(user);
        }

        #endregion


    }
}
