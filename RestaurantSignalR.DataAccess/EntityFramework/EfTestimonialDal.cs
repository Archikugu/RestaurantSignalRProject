using RestaurantSignalR.DataAccess.Abstract;
using RestaurantSignalR.DataAccess.Concrete;
using RestaurantSignalR.DataAccess.Repositories;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.DataAccess.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {
        }
    }
}
