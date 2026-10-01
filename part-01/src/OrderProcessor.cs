namespace RefactoringLab;

public interface IOrderRepository
{
    void Save(int orderId, DateTime processedAt);
}
public interface IEmailSender
{
    void SendEmail(string to, string body);
}
public class SqlOrderRepository : IOrderRepository
{        

    public void Save(int orderId, DateTime processedAt)
    {
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
    }
}

public class SmtpEmailSender : IEmailSender
{       
    public void SendEmail(string to, string body)
    {
        Console.WriteLine($"[SMTP] to={to} body={body}");
    }
}
public class OrderProcessor
{
    private readonly IOrderRepository _repository;
    private readonly IEmailSender _emailSender;

    public OrderProcessor(IOrderRepository repository, IEmailSender emailSender)
    {
        _repository = repository;
        _emailSender = emailSender;
    }

    public void Process(int orderId, string customerEmail)
    {
        _repository.Save(orderId, DateTime.Now);
        _emailSender.SendEmail(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}