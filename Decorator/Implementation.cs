namespace Decorator
{
    /// <summary>
    /// Component (as Interface)
    /// </summary>
    public interface IMailService
    {
        bool SendMail(string message);
    }

    /// <summary>
    /// ConcreteComponent A
    /// </summary>
    public class CloudMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" " +
                $"sent via {nameof(CloudMailService)}.");
            return true;
        }
    }

    /// <summary>
    /// ConcreteComponent B
    /// </summary>
    public class OnPremiseMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" " +
                $"sent via {nameof(OnPremiseMailService)}.");
            return true;
        }
    }

    /// <summary>
    /// Decorator
    /// </summary>
    public abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailService;
        public MailServiceDecoratorBase(IMailService mailService)
        {
            _mailService = mailService;
        }
        public virtual bool SendMail(string message)
        {
            return _mailService.SendMail(message);
        }
    }

    /// <summary>
    /// ConcreteDecorator A
    /// </summary>
    public class StatisticDecorator : MailServiceDecoratorBase
    {
        public StatisticDecorator(IMailService mailService) : base(mailService)
        {
        }

        public override bool SendMail(string message)
        {
            Console.WriteLine($"Collecting statistics in {nameof(StatisticDecorator)}.");
            return base.SendMail(message);
        }
    }

    /// <summary>
    /// ConcreteDecorator B
    /// </summary>
    public class MessageDatabaseDecorator : MailServiceDecoratorBase
    {
        /// <summary>
        /// A list of sent messages
        /// </summary>

        public List<string> SentMessages { get; private set; } = new();
        public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
        {
        }

        public override bool SendMail(string message)
        {
            if(base.SendMail(message))
            {
                // Store sent message
                SentMessages.Add(message);
            }

            return false;
        }
    }

}
