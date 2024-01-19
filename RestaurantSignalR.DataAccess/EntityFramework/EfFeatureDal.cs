using RestaurantSignalR.DataAccess.Abstract;
using RestaurantSignalR.DataAccess.Concrete;
using RestaurantSignalR.DataAccess.Repositories;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.DataAccess.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(Context context) : base(context)
        {
        }
    }
}
