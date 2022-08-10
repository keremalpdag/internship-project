using Microsoft.AspNetCore.Mvc;
using VakifCommerce.BLL.Abstract;
using VakifCommerce.Entities.Dtos;

namespace VakifCommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public ActionResult Login(UserForLoginDTO userForLoginDTO)
        {
            var userToLogin = _authService.Login(userForLoginDTO);
            if (userToLogin.Status == false)
            {
                return BadRequest(userToLogin);
            }
            var result = _authService.CreateAccessToken(userToLogin);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Register")]
        public ActionResult Register(UserForRegistrationDTO userForRegistrationDTO)
        {
            var userExists = _authService.UserExists(userForRegistrationDTO.Email);

            if(userExists == true)
            {
                return BadRequest(userExists);
            }
            var registerResult = _authService.Register(userForRegistrationDTO, userForRegistrationDTO.Password);
            var res = _authService.CreateAccessToken(registerResult);

            if(res != null)
            {
                return Ok(res);
            }

            return BadRequest(res);
        }
    }
}
