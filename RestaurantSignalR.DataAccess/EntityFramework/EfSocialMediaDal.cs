using RestaurantSignalR.DataAccess.Abstract;
using RestaurantSignalR.DataAccess.Concrete;
using RestaurantSignalR.DataAccess.Repositories;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.DataAccess.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(Context context) : base(context)
        {
        }
    }
}
