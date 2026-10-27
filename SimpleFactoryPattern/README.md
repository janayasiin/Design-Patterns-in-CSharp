\# Simple Factory Pattern 🍕



\## Overview

This project demonstrates the \*\*Simple Factory Pattern\*\* using a pizza ordering system in C#.



The Simple Factory Pattern encapsulates object creation in a separate factory class, allowing the client to request objects without directly instantiating concrete classes.



\## Project Structure

\- `Pizza` — Abstract base class containing common pizza operations.

\- `CheesePizza` — Concrete pizza type.

\- `VeggiePizza` — Concrete pizza type.

\- `SimplePizzaFactory` — Creates pizza objects based on the requested type.

\- `PizzaStore` — Uses the factory to create pizzas and performs the preparation steps.

\- `Program.cs` — Demonstrates ordering different pizza types.



\## How It Works

1\. The client creates a `SimplePizzaFactory`.

2\. The factory is passed to `PizzaStore` through its constructor.

3\. The client calls `OrderPizza()` with a pizza type.

4\. `PizzaStore` delegates object creation to `SimplePizzaFactory`.

5\. The pizza is prepared, baked, cut, and boxed.



\## Key Concepts

\- Encapsulation of object creation

\- Composition (HAS-A relationship)

\- Programming to abstractions

\- Separation of responsibilities



\## Example Output



```text

Preparing Cheese Pizza

Baking Cheese Pizza

Cutting Cheese Pizza

Boxing Cheese Pizza



Preparing Veggie Pizza

Baking Veggie Pizza

Cutting Veggie Pizza

Boxing Veggie Pizza

```

