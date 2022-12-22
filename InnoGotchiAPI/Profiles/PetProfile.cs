using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchiAPI.Models;

namespace InnoGotchiAPI.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<PetDTO, PetViewModel>().ReverseMap();
        }
    }
}
