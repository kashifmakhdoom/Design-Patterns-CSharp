using AbstractFactory;

Console.Title = "Abstract Factory";

var pakistanShoppingCartPurchaseFactory = new PakistanShoppingCartPurchaseFactory();
var shoppingCartForPakistan = new ShoppingCart(pakistanShoppingCartPurchaseFactory);
shoppingCartForPakistan.CalculateCost();

var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCost();

Console.ReadKey();