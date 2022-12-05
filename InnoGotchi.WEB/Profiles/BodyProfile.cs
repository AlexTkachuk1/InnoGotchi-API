using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.DAL.Entities;
using InnoGotchi.WEB.Models;

namespace InnoGotchi.BLL.Profiles
{
    public class BodyProfile : Profile
    {
        public BodyProfile()
        {
            CreateMap<BodyDTO, BodyViewModel>().ReverseMap();
        }
    }
}
