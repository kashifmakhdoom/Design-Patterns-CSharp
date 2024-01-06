using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// Product
    /// </summary>
    public class Car
    {
        private readonly List<string> _parts = new();
        private readonly string _carType;

        public Car(string carType)
        {
            _carType = carType;
        }

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach(string part in _parts)
            {
                sb.Append($"Car of type {_carType} has part {part}. ");
            }

            return sb.ToString(); 
        }
    }

    /// <summary>
    /// Builder
    /// </summary>
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }

        public CarBuilder(string carType)
        {
            Car = new Car(carType);
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();

    }

    /// <summary>
    /// ConcreteBuilder A
    /// </summary>
    public class YarisBuilder : CarBuilder
    {
        public YarisBuilder()
            : base("Yaris")
        {
            
        }

        public override void BuildEngine()
        {
            Car.AddPart("not a V8");
        }

        public override void BuildFrame()
        {
            Car.AddPart("4-door with chrome headlights");
        }
    }

    /// <summary>
    /// ConcreteBuilder B
    /// </summary>
    public class LandCruiserBuilder : CarBuilder
    {
        public LandCruiserBuilder()
            : base("LandCruiser")
        {

        }

        public override void BuildEngine()
        {
            Car.AddPart("a powerful V8 engine");
        }

        public override void BuildFrame()
        {
            Car.AddPart("5-door with metalic finish");
        }
    }

    /// <summary>
    /// Director
    /// </summary>
    public class Garage
    {
        private CarBuilder? _builder;

        public Garage()
        {
                
        }

        public void Construct(CarBuilder builder)
        {
            _builder = builder;

            _builder.BuildFrame();
            _builder.BuildEngine();
        }

        public void Show()
        {
            Console.WriteLine(_builder?.Car.ToString());
        }
    }

}
