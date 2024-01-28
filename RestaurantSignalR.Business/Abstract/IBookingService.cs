using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.Business.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        void BookingStatusApproved(int id);
        void BookingStatusCancelled(int id);
    }
}
