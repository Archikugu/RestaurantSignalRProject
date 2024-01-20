using AutoMapper;
using RestaurantSignalR.DTO.AboutDto;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalRApi.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
        }
    }
}
