using AutoMapper;
using RestaurantSignalR.DTO.TestimonialDto;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalRApi.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
        }
    }
}
