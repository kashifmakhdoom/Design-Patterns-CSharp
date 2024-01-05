using Singleton;

Console.Title = "Singleton";

var instanceA = Logger.Instance;
var instanceB = Logger.Instance;

if (instanceA ==  instanceB && instanceA == Logger.Instance)
{
    Console.WriteLine("InstanceA and InstanceB are the same");
}

Console.ReadKey();