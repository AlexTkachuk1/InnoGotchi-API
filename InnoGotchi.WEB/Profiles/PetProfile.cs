using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.WEB.Models;

namespace InnoGotchi.BLL.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<PetDTO, PetViewModel>().ReverseMap();
        }
    }
}
