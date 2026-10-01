using RefactoringLab;


INotification notification = new EmailNotification();
notification.Send("Moamen", "E32al shewaya");
INotification notification1 = new UrgentNotification(notification);
notification1.Send("Moamen", "7nefra6 2Emta");

IOrderRepository repo = new SqlOrderRepository();
IEmailSender repo2 = new SmtpEmailSender();
var processor = new OrderProcessor(repo, repo2);
processor.Process(1001, "customer@example.com");
Console.WriteLine();


IShippingStrategy aramex = new AramexShippingStrategy();
ShippingCostCalculator calculator = new ShippingCostCalculator(aramex);
Console.WriteLine(calculator.Calculate(10m));



