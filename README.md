# 💻 Design Patterns in C#

### Learning Design Patterns Through Practical C# Projects

Welcome to my Design Patterns repository! 👋

This repository documents my journey of learning and implementing **Design Patterns using C#**.

My goal is to understand how each pattern works, what problem it solves, and how to apply it through practical examples.

Each pattern has its own folder containing the **C# implementation** and a **README with a detailed explanation**.

---

## 📚 Implemented Design Patterns

| # | Design Pattern | Category | Implementation |
|---|---|---|---|
| 01 | 👀 Observer | Behavioral | YouTube Notification System |
| 02 | 🎁 Decorator | Structural | Gift Customization System |
| 03 | 🎮 Strategy | Behavioral | Game Character Simulator |
| 04 | 🍕 Simple Factory | Creational Technique | Pizza Ordering System |
| 05 | 🏭 Factory Method | Creational | Regional Pizza Stores |

---

## 👀 01 — Observer Pattern

**Category:** Behavioral Design Pattern

The Observer Pattern allows multiple objects to be notified automatically when the state of another object changes.

### 💡 Implementation

A **YouTube channel notification system** demonstrating two approaches:

- **Push Model:** The Subject sends updated data directly to its Observers.
- **Pull Model:** Observers retrieve updated data from the Subject after receiving a notification.

**Key concepts:** Subject, Observer, Push Model, Pull Model, and loose coupling.

📖 **[Explore Observer Pattern →](./ObserverPattern/)**

---

## 🎁 02 — Decorator Pattern

**Category:** Structural Design Pattern

The Decorator Pattern allows additional behavior to be added to objects dynamically by wrapping them with decorators, without modifying their original classes.

### 💡 Implementation

A **gift customization system** where a basic teddy bear can be decorated with:

- 🎀 **Gift Wrapping:** Adds wrapping to the gift.
- 🎗️ **Ribbon:** Adds a decorative ribbon.
- 💌 **Greeting Card:** Adds a greeting card.

Each decorator wraps the previous object and adds its own cost and description.

**Key concepts:** Open-Closed Principle, dynamic behavior extension, and composition over inheritance.

📖 **[Explore Decorator Pattern →](./DecoratorPattern/)**

---

## 🎮 03 — Strategy Pattern

**Category:** Behavioral Design Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.

### 💡 Implementation

A **game character simulator** with different attack strategies:

- ⚔️ **Sword Attack:** Attacks using a sword.
- 🏹 **Bow Attack:** Attacks using a bow.
- ✨ **Magic Attack:** Attacks using magic.

The application includes two characters, **Warrior** and **Archer**, each with a default attack behavior.

Using `SetAttackBehavior()`, a character can change its attack strategy dynamically at runtime.

**Key concepts:** Programming to an interface, encapsulating what varies, and composition over inheritance.

📖 **[Explore Strategy Pattern →](./StrategyPattern/)**

---

## 🍕 04 — Simple Factory Pattern

**Category:** Creational Technique

Simple Factory encapsulates object creation in a separate factory class, allowing clients to request objects without directly instantiating concrete classes.

### 💡 Implementation

A **pizza ordering system** supporting:

- 🧀 **Cheese Pizza:** Created using `CheesePizza`.
- 🥦 **Veggie Pizza:** Created using `VeggiePizza`.

The `SimplePizzaFactory` class creates the appropriate pizza based on the requested type.

The `PizzaStore` class receives the factory through its constructor and uses it to create, prepare, bake, cut, and box pizzas.

**Key concepts:** Object creation, composition, separation of responsibilities, and programming to abstractions.

📖 **[Explore Simple Factory Pattern →](./SimpleFactoryPattern/)**

---

## 🏭 05 — Factory Method Pattern

**Category:** Creational Design Pattern

The Factory Method Pattern defines a method for creating objects while allowing subclasses to decide which concrete class to instantiate.

### 💡 Implementation

A **pizza ordering system with regional pizza stores**:

- 🗽 **New York Pizza Store:** Creates New York-style cheese pizza.
- 🍕 **Chicago Pizza Store:** Creates Chicago-style cheese pizza with square slices.

The abstract `PizzaStore` class defines the factory method `CreatePizza()` and implements the shared `OrderPizza()` process.

Each concrete store overrides `CreatePizza()`:

- `NYPizzaStore` creates `NYCheesePizza`.
- `ChicagoPizzaStore` creates `ChicagoCheesePizza`.

**Key concepts:** Inheritance, method overriding, runtime polymorphism, object creation, and Dependency Inversion Principle.

📖 **[Explore Factory Method Pattern →](./FactoryMethodPattern/)**

---

## 🔍 Simple Factory vs. Factory Method

| Feature | Simple Factory | Factory Method |
|---|---|---|
| Object creation | Separate factory class | Factory method in subclasses |
| Main approach | Composition | Inheritance |
| Who creates the product? | `SimplePizzaFactory` | Concrete pizza stores |
| Example | `CheesePizza`, `VeggiePizza` | `NYCheesePizza`, `ChicagoCheesePizza` |

---

## 🛠️ Technologies & Tools

- **Language:** C#
- **Framework:** .NET
- **IDE:** Visual Studio
- **Version Control:** Git
- **Repository Hosting:** GitHub

---

## 🎯 Learning Goal

My goal is to build a deeper understanding of software design by **implementing patterns myself instead of only studying their theory**.

This repository will continue to grow as I learn and practice more Design Patterns. 🚀
