\# Factory Method Pattern 🏭🍕



\## Overview

This C# console application demonstrates the \*\*Factory Method Design Pattern\*\* through a pizza ordering system.



Factory Method allows subclasses to decide which concrete product to create while keeping the ordering process in a shared abstract creator.



\## Project Structure

\- `Pizza` — Abstract Product.

\- `NYCheesePizza` — Concrete Product for New York-style pizza.

\- `ChicagoCheesePizza` — Concrete Product for Chicago-style pizza.

\- `PizzaStore` — Abstract Creator that defines `CreatePizza()` and implements `OrderPizza()`.

\- `NYPizzaStore` — Concrete Creator for New York-style pizza.

\- `ChicagoPizzaStore` — Concrete Creator for Chicago-style pizza.

\- `Program.cs` — Demonstrates ordering pizzas from both stores.



\## How It Works

1\. The client creates a concrete pizza store.

2\. The client calls `OrderPizza("cheese")`.

3\. `OrderPizza()` invokes `CreatePizza()`.

4\. The concrete store creates the appropriate pizza.

5\. The pizza is prepared, baked, cut, and boxed.



\## Key Concepts

\- Inheritance and method overriding

\- Runtime polymorphism

\- Abstract Creator and Concrete Creators

\- Abstract Product and Concrete Products

\- Dependency Inversion Principle

\- Encapsulation of object creation



\## Example Output



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

