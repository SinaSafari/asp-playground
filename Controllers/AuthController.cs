using System.Threading.Tasks;
using dnc.Data;
using dnc.Dtos.User;
using dnc.Models;
using Microsoft.AspNetCore.Mvc;

namespace dnc.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo){
            this._authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Regsiter(UserRegisterDto request) {
            ServiceResponse<string> response = await _authRepo.Register(
                new User{Username = request.Username}, 
                request.Password
            );
            if(!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto request) {
            ServiceResponse<string> response = await _authRepo.Login(
                request.Username,
                request.Password
            );
            if(!response.Success) return BadRequest(response);
            return Ok(response);
        }
    }
}