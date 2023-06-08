using BlazorAspNetCoreHostedDemo.Server.Authentication;
using BlazorAspNetCoreHostedDemo.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAspNetCoreHostedDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private UserAccountService _userAccountService;

        public AccountController(UserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            var jwtAuthenticationManager = new JwtAuthenticationManager(_userAccountService);
            var userSession = jwtAuthenticationManager.GenerateJwtToken(loginRequest.UserName, loginRequest.Password);
            if (userSession is null)
                return Unauthorized();
            else
                return userSession;
        }

        [HttpGet]
        [Route("GetUsers")]
        public ActionResult<List<UserAccount>> GetUsers()
        {
            return _userAccountService.GetUsers();

        }

        [HttpGet]
        [Route("GetUser")]
        public ActionResult<UserAccount> GetUser([FromQuery] int userId)
        {
            var userDetail = _userAccountService.GetUser(userId);
            if (userDetail is null)
                return Unauthorized();
            else
                return userDetail;
        }

        [HttpPost]
        [Route("AddUser")]
        public ActionResult AddUser([FromBody] UserAccount user)
        {
            try
            {
                _userAccountService.AddUser(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
