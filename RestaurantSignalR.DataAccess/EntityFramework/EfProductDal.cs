using RestaurantSignalR.DataAccess.Abstract;
using RestaurantSignalR.DataAccess.Concrete;
using RestaurantSignalR.DataAccess.Repositories;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }
    }
}
