# SOLID Principles in C#

This repository demonstrates SOLID principles using simple C# examples.

---

## 1️⃣ Single Responsibility Principle (SRP)

*A class should have only one reason to change*

### Files

| File | Description |
|------|-------------|
| [SRP_Violated.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/SRP_Violated.cs) | One class handling multiple responsibilities |
| [SRP_Followed.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/SRP_Followed.cs) | Responsibilities divided into separate classes |

---

## 2️⃣ Open/Closed Principle (OCP)

*Open for extension, closed for modification*

### Files

| File | Description |
|------|-------------|
| [OCP_Violated.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/OCP_Violated.cs) | Uses conditional logic for vehicle types |
| [OCP_Followed.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/OCP_Followed.cs) | Uses abstraction to extend behavior |

---

## 3️⃣ Liskov Substitution Principle (LSP)

*Subclasses should be replaceable without breaking behavior*

### Files

| File | Description |
|------|-------------|
| [LSP_Violated.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/LSP_Violated.cs) | Incorrect inheritance (e.g., Bicycle with engine logic) |
| [LSP_Followed.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/LSP_Followed.cs) | Proper abstraction & hierarchy |

---

## 4️⃣ Interface Segregation Principle (ISP)

*Do not force clients to implement unnecessary methods*

### Files

| File | Description |
|------|-------------|
| [ISP_Violated.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/ISP_Violated.cs) | Fat interface with unrelated methods |
| [ISP_Followed.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/ISP_Followed.cs) | Small, specific interfaces |

---

## 5️⃣ Dependency Inversion Principle (DIP)

*Depend on abstractions, not concrete classes*

### Files

| File | Description |
|------|-------------|
| [DIP_Violated.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/DIP_Violated.cs) | High-level module depends on concrete class |
| [DIP_Followed.cs](https://github.com/ganeshmali7/Aware-of-SOLID-Principles/blob/main/DIP_Followed.cs) | Uses interface & dependency injection |

---
