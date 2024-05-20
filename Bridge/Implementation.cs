namespace Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Menu
    {
        public readonly ICoupon _coupon = null!;
        public abstract decimal CalculatePrice();

        protected Menu(ICoupon coupon)
        {
            _coupon = coupon;
        }
    }

    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class StandardMenu : Menu
    {
        private readonly decimal _price = 20m;
        public StandardMenu(ICoupon coupon) : base(coupon)
        {

        }
        public override decimal CalculatePrice()
        {
            return _price - _coupon.CouponValue;
        }
    }

    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class PartyMenu : Menu
    {
        private readonly decimal _price = 30m;
        public PartyMenu(ICoupon coupon) : base(coupon)
        {
                
        }
        public override decimal CalculatePrice()
        {
            return _price - _coupon.CouponValue;
        }
    }

    /// <summary>
    /// Implementor
    /// </summary>
    public interface ICoupon
    {
        decimal CouponValue { get; }
    }

    /// <summary>
    /// ConcreteImplementator
    /// </summary>
    public class NoCoupon : ICoupon
    {
        public decimal CouponValue
        {
            get => 0;
        }
    }

    /// <summary>
    /// ConcreteImplementator
    /// </summary>
    public class WeekendCoupon : ICoupon
    {
        public decimal CouponValue
        {
            get => 2.0m;
        }
    }

    /// <summary>
    /// ConcreteImplementator
    /// </summary>
    public class BirthdayCoupon : ICoupon
    {
        public decimal CouponValue
        {
            get => 5.0m;
        }
    }

}