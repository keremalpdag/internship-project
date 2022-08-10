using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt;
using VakifCommerce.Entities.Dtos;

namespace VakifCommerce.BLL.Abstract
{
    public interface IAuthService
    {
        User Register(UserForRegistrationDTO userForRegistrationDTO, string password);
        User Login(UserForLoginDTO userForLoginDTO);
        bool UserExists(string email);
        AccessToken CreateAccessToken(User user);
    }
}
