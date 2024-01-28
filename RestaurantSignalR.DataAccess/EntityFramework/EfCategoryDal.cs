using RestaurantSignalR.DataAccess.Abstract;
using RestaurantSignalR.DataAccess.Concrete;
using RestaurantSignalR.DataAccess.Repositories;
using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.DataAccess.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
        public int ActiveCategoryCount()
        {
            using var context = new Context();
            return context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context = new Context();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new Context();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
