using AutoMapper;
using RestaurantSignalR.DTO.SliderDto;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalRApi.Mapping
{
    public class SliderMapping : Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
        }
    }
}
