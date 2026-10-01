# Part 01 — answers

---
## ShippingCostCalculator

- **What was the problem?** 
  It violated the Open/Closed Principle (OCP). The class used a `switch` statement based on a string (`carrier`). This meant that every time a new shipping carrier was introduced, the core class had to be manually modified, creating a rigid and hard-to-maintain structure.
- **What did you change?** 
  I implemented the Strategy Pattern. I extracted the calculation logic into separate classes for each carrier (e.g., `AramexShippingStrategy`) that implement a common `IShippingStrategy` interface. The `ShippingCostCalculator` now uses Composition to depend on this interface, allowing new carriers to be added without modifying existing code.

---
## OrderProcessor

- **What was the problem?** 
  It violated the Dependency Inversion Principle (DIP) because it suffered from tight coupling. The high-level module (`OrderProcessor`) directly instantiated low-level modules (`SqlOrderRepository` and `SmtpEmailSender`) using the `new` keyword, making it impossible to switch dependencies (like using a different database or email provider) without changing the core logic.
- **What did you change?** 
  I created abstractions (`IOrderRepository` and `IEmailSender`). The low-level modules now implement these interfaces, and the `OrderProcessor` depends on them via Constructor Injection (Composition). This decouples the classes and makes the code testable and flexible.

---
## Notifications

- **What was the problem?** 
  It suffered from a "Combinatorial Explosion" of classes due to the misuse of deep inheritance to combine different dimensions (Channel, Priority, and Timing). Creating static classes for every possible combination (e.g., `UrgentScheduledSmsNotification`) violated OCP and made the system impossible to scale.
- **What did you change?** 
  I replaced static inheritance with dynamic Composition by applying the Decorator Pattern (alongside Strategy). I made base channels (`EmailNotification`, `SmsNotification`) and properties (`UrgentNotification`, `ScheduledNotification`) implement the same `INotification` interface. Properties now wrap the base channels at runtime without creating new combinatorial classes.

---
## Proof

- **New carrier file(s):** e.g., `AramexShippingStrategy.cs`, `FedExShippingStrategy.cs`, `DhlShippingStrategy.cs` (or any newly added carrier like `UpsShippingStrategy.cs`).
- **New notification channel file(s):** e.g., `UrgentNotification.cs`, `ScheduledNotification.cs` (and any future channel like `PushNotification.cs` can be added seamlessly).
- **Existing classes left unchanged? (yes/no):** Yes