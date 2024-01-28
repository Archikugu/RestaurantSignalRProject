using RestaurantSignalR.Entities.Concrete;

namespace RestaurantSignalR.DataAccess.Abstract
{
    public interface IBookingDal : IGenericDal<Booking>
    {
        void BookingStatusApproved(int id);
        void BookingStatusCancelled(int id);
    }
}
