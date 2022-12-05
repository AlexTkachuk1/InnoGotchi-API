using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Profiles
{
    public class BodyProfile : Profile
    {
        public BodyProfile()
        {
            CreateMap<Body, BodyDTO>().ReverseMap();
        }
    }
}
