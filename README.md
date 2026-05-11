1️⃣ Single Responsibility Principle (SRP)

A class should have only one reason to change


















FileDescriptionSRP_Violated.csOne class handling multiple responsibilitiesSRP_Followed.csResponsibilities divided into separate classes

2️⃣ Open/Closed Principle (OCP)

Open for extension, closed for modification


















FileDescriptionOCP_Violated.csUses conditional logic for vehicle typesOCP_Followed.csUses abstraction to extend behavior

3️⃣ Liskov Substitution Principle (LSP)

Subclasses should be replaceable without breaking behavior


















FileDescriptionLSP_Violated.csIncorrect inheritance (e.g., Bicycle with engine logic)LSP_Followed.csProper abstraction & hierarchy

4️⃣ Interface Segregation Principle (ISP)

Do not force clients to implement unnecessary methods


















FileDescriptionISP_Violated.csFat interface with unrelated methodsISP_Followed.csSmall, specific interfaces

5️⃣ Dependency Inversion Principle (DIP)

Depend on abstractions, not concrete classes


















FileDescriptionDIP_Violated.csHigh-level module depends on concrete classDIP_Followed.csUses interface & dependency injection
