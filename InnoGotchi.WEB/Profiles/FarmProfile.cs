using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.WEB.Models;

namespace InnoGotchi.BLL.Profiles
{
    public class FarmProfile : Profile
    {
        public FarmProfile()
        {
            CreateMap<FarmDTO, FarmViewModel>().ReverseMap();
        }
    }
}
