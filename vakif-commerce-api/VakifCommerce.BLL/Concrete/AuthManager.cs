using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using VakifCommerce.BLL.Abstract;
using VakifCommerce.Entities.Dtos;

namespace VakifCommerce.BLL.Concrete
{
    internal class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager (IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public AccessToken CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);

            return accessToken;
        }

        public User Login(UserForLoginDTO userForLoginDTO)
        {
            string notFoundError = "User does not exist";
            string doesNotMatch = "Incorrect Password";
            var checkUser = _userService.GetByMail(userForLoginDTO.Email);
            if(checkUser == null)
            {
                throw new Exception(notFoundError);
            }

            if(!HashingHelper.VerifyPasswordHash(userForLoginDTO.Password, checkUser.PasswordHash, checkUser.PasswordSalt))
            {
                throw new Exception(doesNotMatch);
            }

            return checkUser;
        }

        public bool UserExists(string email)
        {
            if(_userService.GetByMail(email) != null)
            {
                return true;
            }
            return false;
        }

        public User Register(UserForRegistrationDTO userForRegistrationDTO, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var user = new User
            {
                Email = userForRegistrationDTO.Email,
                FirstName = userForRegistrationDTO.FirstName,
                LastName = userForRegistrationDTO.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return user;
        }
    }
}
