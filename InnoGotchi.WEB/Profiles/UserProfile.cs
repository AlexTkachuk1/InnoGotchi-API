using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.WEB.Models;
using NLayerApp.WEB.Models;

namespace InnoGotchi.BLL.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, UserViewModel>().ReverseMap();
            CreateMap<UserDTO, RegistrationViewModel>().ReverseMap();
        }
    }
}
