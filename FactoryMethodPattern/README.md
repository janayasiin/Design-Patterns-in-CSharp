# 🏭 Factory Method Pattern in C#

### Creating Regional Pizzas Using the Factory Method Design Pattern 🍕

This project demonstrates the **Factory Method Design Pattern** through a practical **pizza ordering system built with C#**.

The main idea is to define a method for creating objects while allowing **subclasses to decide which concrete product to instantiate**.

---

## 📌 Pattern Overview

The Factory Method Pattern is a **Creational Design Pattern** that delegates object creation to subclasses.

Instead of having a separate factory class, each concrete pizza store implements its own factory method.

> 💡 **Key Idea:** Define an interface for creating an object, but let subclasses decide which class to instantiate.

---

## 🏗️ Project Structure

| Class | Design Pattern Role | Responsibility |
|---|---|---|
| `Pizza` | Abstract Product | Defines common pizza operations. |
| `NYCheesePizza` | Concrete Product | Represents New York-style cheese pizza. |
| `ChicagoCheesePizza` | Concrete Product | Represents Chicago-style cheese pizza. |
| `PizzaStore` | Abstract Creator | Defines `CreatePizza()` and implements `OrderPizza()`. |
| `NYPizzaStore` | Concrete Creator | Creates New York-style pizzas. |
| `ChicagoPizzaStore` | Concrete Creator | Creates Chicago-style pizzas. |
| `Program.cs` | Client | Demonstrates ordering pizzas from different stores. |

---

## ⚙️ How It Works

**1. Create a concrete store**

The client creates an instance of `NYPizzaStore` or `ChicagoPizzaStore`.

**2. Order a pizza**

The client calls `OrderPizza("cheese")`.

**3. Invoke the factory method**

The shared `OrderPizza()` method calls `CreatePizza()`.

**4. Create the concrete product**

The concrete store determines which pizza class to instantiate:

- `NYPizzaStore` creates `NYCheesePizza`.
- `ChicagoPizzaStore` creates `ChicagoCheesePizza`.

**5. Prepare the order**

The pizza goes through four operations:

**Prepare → Bake → Cut → Box**

---

## 🔗 Class Relationships

### Inheritance (IS-A)

- `NYCheesePizza` is a `Pizza`.
- `ChicagoCheesePizza` is a `Pizza`.
- `NYPizzaStore` is a `PizzaStore`.
- `ChicagoPizzaStore` is a `PizzaStore`.

### Dependency on Abstractions

The abstract `PizzaStore` works with the abstract `Pizza` type rather than directly depending on concrete pizza classes.

Each concrete store is responsible for creating its corresponding concrete product.

---

## 🧠 Key Concepts

- **Factory Method:** Defines a method for creating products that subclasses implement.
- **Inheritance:** Concrete stores inherit from the abstract `PizzaStore`.
- **Method Overriding:** Each concrete store overrides `CreatePizza()`.
- **Runtime Polymorphism:** The appropriate `CreatePizza()` implementation is selected based on the actual store object.
- **Encapsulation of Object Creation:** Product creation is handled by the concrete creators.
- **Dependency Inversion Principle:** High-level ordering logic depends on the abstract `Pizza` type rather than concrete pizza implementations.

---

## 💻 Example Output

```text
Preparing New York Cheese Pizza
Baking New York Cheese Pizza
Cutting New York Cheese Pizza
Boxing New York Cheese Pizza

Preparing Chicago Cheese Pizza
Baking Chicago Cheese Pizza
Cutting Chicago Cheese Pizza into square slices
Boxing Chicago Cheese Pizza
```

---

## 🔍 Simple Factory vs. Factory Method

| Feature | Simple Factory | Factory Method |
|---|---|---|
| Object creation | Separate factory class | Factory method in subclasses |
| Main approach | Composition | Inheritance |
| Factory implementation | `SimplePizzaFactory` | `NYPizzaStore`, `ChicagoPizzaStore` |
| Products | `CheesePizza`, `VeggiePizza` | `NYCheesePizza`, `ChicagoCheesePizza` |
| Extending creation behavior | Modify or replace the factory | Add a new concrete creator |

---

## 🎯 What I Learned

Through this implementation, I practiced:

- Understanding **Abstract Creator** and **Concrete Creator** roles.
- Understanding **Abstract Product** and **Concrete Product** roles.
- Using inheritance and method overriding.
- Applying runtime polymorphism.
- Separating object creation from the ordering process.
- Understanding the **Dependency Inversion Principle**.

---

### 📚 Part of My Design Patterns Learning Journey

This project is one of my practical C# implementations for understanding and applying Design Patterns.
