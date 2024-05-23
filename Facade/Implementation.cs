namespace Facade
{
    /// <summary>
    /// Subsystem Class
    /// </summary>
    public class OrderService
    {
        public bool HasEnoughOrders(int customerId)
        {
            //TODO: check does the customer has enough orders?
            return (customerId > 5);
        }
    }

    /// <summary>
    /// Subsystem Class
    /// </summary>
    public class CustomerDiscountBaseService
    {
        public double CalculateDiscountBase(int customerId)
        {
            return (customerId > 8) ? 10 : 20;
        }
    }

    /// <summary>
    /// Subsystem Class
    /// </summary>
    public class DayOfTheWeekFactorService
    {
        public double CalculatedayOfTheWeekFactor()
        {
            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Saturday: 
                case DayOfWeek.Sunday:
                    return 0.5;
                default:
                    return 1.5;
            }
        }
    }

    /// <summary>
    /// Facade
    /// </summary>
    public class DiscountFacade
    {
        private readonly OrderService _orderService = new();
        private readonly CustomerDiscountBaseService _customerDiscountBaseService = new();
        private readonly DayOfTheWeekFactorService _dayOfTheWeekFactorService = new();

        public double CalculateDiscountPercentage(int customerId)
        {
            if(!_orderService.HasEnoughOrders(customerId))
            {
                return 0;
            }

            return _customerDiscountBaseService.CalculateDiscountBase(customerId)
                    * _dayOfTheWeekFactorService.CalculatedayOfTheWeekFactor();
        }
    }
}
