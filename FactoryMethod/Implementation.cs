namespace FactoryMethod
{

    /// <summary>
    /// Product
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;

    }

    /// <summary>
    /// ConcreteProduct A
    /// </summary>
    public class CountryDiscountService: DiscountService 
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch(_countryIdentifier)
                {
                    case "PK":
                        return 30;
                    case "US":
                        return 20;
                    default:
                        return 10;

                }
            }
        }
    }

    /// <summary>
    /// ConcreteProduct B
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _codeIdentifier;

        public CodeDiscountService(Guid codeIdentifier)
        {
            _codeIdentifier = codeIdentifier;
        }

        public override int DiscountPercentage
        {
            // each code returns the same fixed percentage,
            // but a code can only be used once. You may want to pre-check
            // the code whether it's already been used 
            get => 15;
        }
    }

    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    /// <summary>
    /// ConcreteCreator A
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;
        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier= countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    /// <summary>
    /// ConcreteCreator B
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _codeIdentifier;
        public CodeDiscountFactory(Guid codeIdentifier)
        {
            _codeIdentifier = codeIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_codeIdentifier);
        }
    }

}
