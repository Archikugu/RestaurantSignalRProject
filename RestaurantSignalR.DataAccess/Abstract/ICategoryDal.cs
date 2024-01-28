using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.DataAccess.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
    }
}
