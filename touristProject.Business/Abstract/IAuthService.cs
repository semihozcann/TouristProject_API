using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Core.Entities.Concrete;
using touristProject.Core.Utilities.Result.Abstract;
using touristProject.Core.Utilities.Security.JWT;
using touristProject.Entities.DTOs.Users;

namespace touristProject.Business.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<User>> RegisterAsync(UserForRegisterDto userForRegisterDto, string password);
        Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto);
        Task<IResult> UserExistsAsync(string email);
        Task<IDataResult<AccessToken>> CreateAccessToken(User user);
    }
}
