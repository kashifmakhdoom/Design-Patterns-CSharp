using ObjectAdapter = Adapter.ObjectAdapter;
using ClassAdapter = Adapter.ClassAdapter;


Console.Title = "Adapter";

// Object Adapter Example
Console.WriteLine("*** OBJECT ADAPTER EXAMPLE ***");
ObjectAdapter.ICityAdapter objectAdapter = new ObjectAdapter.CityAdapter();
var objectAdapterCity = objectAdapter.GetCity();

Console.WriteLine($"{objectAdapterCity.FullName}", objectAdapterCity.Inhibitants);

// Class Adapter Example
Console.WriteLine("*** CLASS ADAPTER EXAMPLE ***");
ClassAdapter.ICityAdapter classAdapter = new ClassAdapter.CityAdapter();
var classAdapterCity = classAdapter.GetCity();

Console.WriteLine($"{classAdapterCity.FullName}", classAdapterCity.Inhibitants);

Console.ReadKey();