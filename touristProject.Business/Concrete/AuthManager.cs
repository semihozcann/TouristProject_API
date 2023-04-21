﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using touristProject.Business.Abstract;
using touristProject.Business.Constants;
using touristProject.Business.ValidationRules.FluentValidation.Users;
using touristProject.Core.Aspects.Autofac;
using touristProject.Core.Entities.Concrete;
using touristProject.Core.Utilities.Result.Abstract;
using touristProject.Core.Utilities.Result.Concrete;
using touristProject.Core.Utilities.Security.Hashing;
using touristProject.Core.Utilities.Security.JWT;
using touristProject.Entities.DTOs.Users;

namespace touristProject.Business.Concrete
{
    public class AuthManager : IAuthService
    {

        #region Injection

        private readonly IUserService _userService;
        ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        #endregion


        #region RegisterAsync

        [ValidationAspect(typeof(AuthRegisterValidator))]
        public async Task<IDataResult<User>> RegisterAsync(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            await _userService.AddAsync(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        #endregion

        #region LoginAsync

        public async Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto)
        {
            var userToCheck = await _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
        }

        #endregion

        #region UserExistsAsync

        public async Task<IResult> UserExistsAsync(string email)
        {
            if (await _userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        #endregion

        #region CreateAccessToken

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
        {
            var claims = await _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        #endregion


    }
}
