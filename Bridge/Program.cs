using Bridge;

Console.Title = "Bridge";

var noCoupon = new NoCoupon();
var weekendCoupon = new WeekendCoupon();
var birthdayCoupon = new BirthdayCoupon();

var standardMenu = new StandardMenu(noCoupon);
Console.WriteLine($"Standard Menu: no coupon: {standardMenu.CalculatePrice()} euro");

standardMenu = new StandardMenu(weekendCoupon);
Console.WriteLine($"Standard Menu: weekend coupon: {standardMenu.CalculatePrice()} euro");

standardMenu = new StandardMenu(birthdayCoupon);
Console.WriteLine($"Standard Menu: party coupon: {standardMenu.CalculatePrice()} euro");


Console.ReadKey();