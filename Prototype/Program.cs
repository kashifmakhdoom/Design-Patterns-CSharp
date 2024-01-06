using Prototype;

Console.Title = "Prototype";

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("John", managerClone);
var employeeClone = (Employee)employee.Clone(true); //deep clone 
Console.WriteLine($"Employee was cloned: {employeeClone.Name}" +
    $" with manager {employeeClone.Manager.Name}");

// change the manager name to test deep clone
managerClone.Name = "Mack";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}" +
    $" with manager {employeeClone.Manager.Name}");

Console.ReadKey();