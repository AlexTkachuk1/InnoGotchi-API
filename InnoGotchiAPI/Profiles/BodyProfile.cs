using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchiAPI.Models;

namespace InnoGotchiAPI.Profiles
{
    public class BodyProfile : Profile
    {
        public BodyProfile()
        {
            CreateMap<BodyDTO, BodyViewModel>().ReverseMap();
        }
    }
}
