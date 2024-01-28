using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        int TCategoryCount();
        int TActiveCategoryCount();
        int TPassiveCategoryCount();
    }
}
