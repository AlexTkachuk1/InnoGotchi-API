using AutoMapper;
using InnoGotchi.BLL.DTO;
using InnoGotchi.DAL.Entities;

namespace InnoGotchi.BLL.Profiles
{
    public class FarmProfile : Profile
    {
        public FarmProfile()
        {
            CreateMap<Farm, FarmDTO>().ReverseMap();
        }
    }
}
