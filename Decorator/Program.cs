using Decorator;

Console.Title = "Decorator";

var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Hi there!");

var onPremiseMailService = new OnPremiseMailService();
onPremiseMailService.SendMail("Hi there!");

// Add behaviour
var statisticsDecorator = new StatisticDecorator(cloudMailService);
statisticsDecorator.SendMail($"Hi there via {nameof(StatisticDecorator)} wrapper");

// Add behaviour
var messageDatabaseDecorator = new MessageDatabaseDecorator(onPremiseMailService);
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 1");
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 2");

foreach (var message in messageDatabaseDecorator.SentMessages)
{
    Console.WriteLine($"Stored message: \"{message}\"");
}

Console.ReadKey();