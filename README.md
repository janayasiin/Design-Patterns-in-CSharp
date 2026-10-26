# Design Patterns in C# 💻

This repository documents my journey of learning and implementing **Design Patterns using C#**.

The goal is to understand how each pattern works, what problem it solves, and how to apply it through practical examples.

Each design pattern has its own folder containing the implementation and a README explaining the concept.

## 📚 Implemented Design Patterns

### 01 — Observer Pattern 👀

A Behavioral Design Pattern that allows multiple objects to be notified automatically when the state of another object changes.

I implemented the Observer Pattern using a **YouTube channel notification system**, exploring two approaches:

- **Push Model:** The Subject sends updated data directly to its Observers.
- **Pull Model:** Observers retrieve updated data from the Subject after receiving a notification.

📖 **[Read the explanation and explore the code](./ObserverPattern/)**

---

### 02 — Decorator Pattern 🎁

A Structural Design Pattern that allows additional behavior to be added to objects dynamically by wrapping them with decorators, without modifying their original classes.

I implemented the Decorator Pattern using a **gift customization system**, where a basic teddy bear can be decorated with optional additions:

- **Gift Wrapping:** Adds wrapping to the gift.
- **Ribbon:** Adds a decorative ribbon.
- **Greeting Card:** Adds a greeting card.

Each decorator wraps the previous object and adds its own cost and description.

This implementation demonstrates how to combine features dynamically while following the **Open-Closed Principle** and favoring **composition over inheritance**.

📖 **[Read the explanation and explore the code](./DecoratorPattern/)**

---

## 🛠️ Technologies

- C#
- .NET
- Visual Studio
- Git & GitHub

---

## 🎯 Learning Goal

My goal is to build a deeper understanding of software design by implementing patterns myself instead of only studying their theory.

This repository will continue to grow as I learn and practice more Design Patterns. 🚀
