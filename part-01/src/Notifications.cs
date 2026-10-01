namespace RefactoringLab;

public interface INotification
{
    void Send(string to, string message);
}

public class EmailNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsNotification : INotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}

public class UrgentNotification : INotification
{
    private readonly INotification _notifier;
    public UrgentNotification( INotification notifier ) {
        _notifier = notifier;
    }
    public void Send(string to, string message)
    {
        _notifier.Send(to, $"[URGENT] {message}");
    }
}
public class ScheduledNotification : INotification
{
    private readonly INotification _notifier;
    public DateTime SendAt { get; set; }
    public ScheduledNotification(INotification notifier, DateTime sendAt)
    {
        _notifier = notifier;
        SendAt = sendAt;
    }
    public void Send(string to, string message)
    {
        Console.WriteLine($"[Scheduled for: {SendAt:g}]");
        _notifier.Send(to, message);
    }
}