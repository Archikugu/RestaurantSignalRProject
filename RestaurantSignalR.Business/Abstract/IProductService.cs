using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
    }
}
