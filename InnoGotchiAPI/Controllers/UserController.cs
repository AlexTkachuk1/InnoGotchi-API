using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.BLL.Interfaces;
using InnoGotchi.DAL.Entities;
using InnoGotchiAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace InnoGotchiAPI.Controllers
{
    public class UserController : Controller
    {
        public readonly IService<User, UserDTO> _userService;
        public readonly IMapper _mapper;
        public UserController(
            IMapper mapper,
            IService<User, UserDTO> userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationViewModel registrationViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Register", registrationViewModel);
            }
            var userDTO = _mapper.Map<UserDTO>(registrationViewModel);

            _userService.Create(userDTO);

            return View("Index");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public string Login(string username)
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
