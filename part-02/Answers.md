# Part 02 — answers

---
## Reports

- **What was the problem?**
  There was massive code duplication across the three exporter classes (`CsvReportExporter`, `JsonReportExporter`, and `TextReportExporter`). Methods like `Load`, `Validate`, `Save`, and the overall flow inside `Export` were identical in all classes, violating the DRY (Don't Repeat Yourself) principle.
- **What did you change?**
  I applied the Template Method Pattern by creating an abstract base class `ReportExporter`. I moved all the shared methods and the main `Export()` flow into this base class. The specific exporters now inherit from this class and only override the `protected abstract string Format()` method.
- **Why did you choose that approach?**
  An abstract class is the perfect fit here because it allows us to share actual boilerplate implementation, unlike an interface which only defines a contract. The Template Method pattern encapsulates the invariant algorithm steps in the base class while letting subclasses define the variant steps (the formatting), effectively eliminating code duplication and adhering to the Open/Closed Principle.

---
## Enrollment

- **What was the problem?**
  The client code (in `Program.cs`) was heavily burdened with the complex orchestration of four separate subsystems (`PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService`). This created tight coupling; the client had to know exactly how to instantiate them and the specific order to call their methods.
- **What did you change?**
  I implemented the Facade Pattern by creating an `EnrollmentFacade` class. This new class encapsulates the initialization and execution logic of the four subsystems. The client now simply instantiates the facade and calls a single `Enroll()` method.
- **Why did you choose that approach?**
  The Facade Pattern provides a simplified, unified interface to a complex set of subsystems. This approach decouples the client from the underlying complex components. If the enrollment process changes in the future (e.g., adding an SMS service or changing the order of execution), we only need to update the Facade class, leaving the client code completely untouched.