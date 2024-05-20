using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ObjectAdapter
{
    public class CityFromExternalSystem
    {
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public int Inhibitants { get; private set; }

        public CityFromExternalSystem(string name, string nickname, int inhibitants)
        {
            Name = name;
            NickName = nickname;
            Inhibitants = inhibitants;
        }
    }

    /// <summary>
    /// Adaptee
    /// </summary>
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity() 
        {
            return new CityFromExternalSystem("Karachi", "khi", 20000000);
        }
    }

    public class City
    { 
        public string FullName { get; private set;}
        public long Inhibitants { get; private set; }

        public City(string fullname, long inhibitants)
        {
            FullName = fullname;
            Inhibitants = inhibitants;
        }
    }

    /// <summary>
    /// Target
    /// </summary>
    public interface ICityAdapter
    {
        City GetCity();
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class CityAdapter : ICityAdapter
    {
        public ExternalSystem ExternalSystem { get; private set; } = new();
        public City GetCity()
        {
            // Call into the external system
            var cityFromExternalSystem = ExternalSystem.GetCity();

            // Adapt from souce to target
            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName} ", cityFromExternalSystem.Inhibitants);
        }
    }
}
