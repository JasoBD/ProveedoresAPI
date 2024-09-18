using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProveedoresApi.Models;
using ProveedoresApi.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace JwtInDotnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase

    {
        private readonly TokenRepository _tokenService;
        public LoginController(TokenRepository _tokenService)
        {
            this._tokenService = _tokenService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserToken loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Username) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest("Credenciales no válidas.");
            }
            //If login usrename and password are correct then proceed to generate token// Aquí deberías validar el usuario, por ejemplo, contra una base de datos.
            if (loginRequest.Username == "Jaondres" && loginRequest.Password == "12345") // Validación simple
            {
                var token = this._tokenService.GenerateToken(loginRequest.Username);
                return Ok(new { Token = token });
            }
            return Unauthorized();

        }
    }



}