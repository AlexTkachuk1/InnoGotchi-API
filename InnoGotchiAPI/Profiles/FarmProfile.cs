using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchiAPI.Models;

namespace InnoGotchiAPI.Profiles
{
    public class FarmProfile : Profile
    {
        public FarmProfile()
        {
            CreateMap<FarmDTO, FarmViewModel>().ReverseMap();
        }
    }
}
