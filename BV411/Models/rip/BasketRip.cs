using BV411.Models.main;
using BV411.Models.transport;

namespace BV411.Models.rip
{
    public static class BasketRip
    {
        static public Basket GetBasket(int id)
        {
            foreach (var item in UserRip.users)
            {
                if (item.Basket.Id == id)
                {
                    return item.Basket;
                }
            }
            return new Basket();
        }
    }
}
