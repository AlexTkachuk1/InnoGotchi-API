using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<Pet, PetDTO>().ReverseMap();
        }
    }
}
