using Microsoft.EntityFrameworkCore;
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

        public List<Product> GetProductsWithCategories()
        {
            var context = new Context();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
}
