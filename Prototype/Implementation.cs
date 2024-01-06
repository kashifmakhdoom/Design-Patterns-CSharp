using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Prototype
{
    ///<summary>
    /// Prototype
    ///</summary>
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract Person Clone(bool isDeepClone);
    }

    ///<summary>
    /// ConcretePrototype A
    ///</summary>
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
        public override Person Clone(bool isDeepClone=false)
        {
            // deep copy
            if (isDeepClone)
            {
                var objectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Manager>(objectAsJson);
            }

            // shallow copy
            return (Person)MemberwiseClone();
        }
    }

    ///<summary>
    /// ConcretePrototype B
    ///</summary>
    public class Employee : Person
    {
        public override string Name { get; set; }
        public Manager Manager { get; set; }

        public Employee(string name, Manager manager)
        {
            Name = name;
            Manager = manager;
        }
        public override Person Clone(bool isDeepClone=false)
        {
            // deep copy
            if (isDeepClone)
            {
                var objectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Employee>(objectAsJson);
            }

            // shallow copy
            return (Person)MemberwiseClone();
        }
    }
}
