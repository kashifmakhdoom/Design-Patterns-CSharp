namespace AbstractFactory
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostService CreateShippingCostService();

        string ToName { get; }

    }

    /// <summary>
    /// AbstractProduct
    /// </summary>
    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class PakistanDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 10;
    }

    /// <summary>
    /// AbstractProduct
    /// </summary>
    public interface IShippingCostService
    {
        decimal ShippingCost { get; }
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class PakistanShippingCostService : IShippingCostService
    {
        public decimal ShippingCost => 20;
    }

    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class FranceShippingCostService : IShippingCostService
    {
        public decimal ShippingCost => 10;
    }

    // *** FACTORIES ***

    /// <summary>
    /// ConcreteFactory
    /// </summary>
    public class PakistanShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public string ToName => "Pakistan";

        public IDiscountService CreateDiscountService()
        {
            return new PakistanDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new PakistanShippingCostService();
        }
    }

    /// <summary>
    /// ConcreteFactory
    /// </summary>
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public string ToName => "France";

        public IDiscountService CreateDiscountService()
        {
            return new FranceDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new FranceShippingCostService();
        }
    }

    /// <summary>
    /// Client
    /// </summary>
    public class ShoppingCart
    {
        private readonly IShoppingCartPurchaseFactory _factory;
        private readonly IDiscountService _discountService;
        private readonly IShippingCostService _shippingCostService;
        private int _orderCost;
        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _factory = factory;
            _discountService = factory.CreateDiscountService();
            _shippingCostService = factory.CreateShippingCostService();

            _orderCost = 200;
        }

        public void CalculateCost()
        {
            Console.WriteLine($"Total Cost for {_factory.ToName } = {_orderCost - (_orderCost / 100 * _discountService.DiscountPercentage) + _shippingCostService.ShippingCost}");
        }
    }
}
