# 🍕 Simple Factory Pattern in C#

### Creating Pizza Objects Using a Simple Factory

This project demonstrates the **Simple Factory Pattern** through a practical **pizza ordering system built with C#**.

The main idea is to **encapsulate object creation** inside a separate factory class, so the client does not need to instantiate concrete pizza classes directly.

---

## 📌 Pattern Overview

Instead of creating objects directly using:

`new CheesePizza()`

The client requests a pizza from the factory:

`factory.CreatePizza("cheese")`

The factory decides which concrete pizza class to instantiate based on the requested type.

> 💡 **Key Idea:** Separate object creation from the code that uses the objects.

---

## 🏗️ Project Structure

| Class | Responsibility |
|---|---|
| `Pizza` | Abstract base class defining common pizza operations. |
| `CheesePizza` | Concrete pizza class representing cheese pizza. |
| `VeggiePizza` | Concrete pizza class representing veggie pizza. |
| `SimplePizzaFactory` | Creates the appropriate pizza object based on its type. |
| `PizzaStore` | Uses the factory to create pizzas and handles the ordering process. |
| `Program.cs` | Demonstrates ordering different pizza types. |

---

## ⚙️ How It Works

**1. Create the factory**

The client creates an instance of `SimplePizzaFactory`.

**2. Create the pizza store**

The factory is passed to `PizzaStore` through its constructor.

**3. Order a pizza**

The client calls `OrderPizza("cheese")` or `OrderPizza("veggie")`.

**4. Delegate object creation**

`PizzaStore` calls `SimplePizzaFactory.CreatePizza()` to obtain the appropriate pizza object.

**5. Prepare the order**

The pizza goes through four operations:

**Prepare → Bake → Cut → Box**

---

## 🔗 Class Relationships

**Inheritance (IS-A):**

- `CheesePizza` is a `Pizza`.
- `VeggiePizza` is a `Pizza`.

**Composition / HAS-A:**

- `PizzaStore` has a reference to `SimplePizzaFactory`.

The store delegates pizza creation to the factory rather than directly creating concrete pizza objects.

---

## 🧠 Key Concepts

- **Encapsulation of Object Creation:** The factory handles the creation of concrete pizza objects.
- **Composition (HAS-A):** `PizzaStore` uses a factory object.
- **Programming to Abstractions:** The factory returns the abstract `Pizza` type.
- **Separation of Responsibilities:** The factory creates pizzas, while the store manages the ordering process.
- **Reduced Coupling:** The store does not directly depend on `CheesePizza` or `VeggiePizza`.

---

## 💻 Example Output

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

---

## 🎯 What I Learned

Through this implementation, I practiced:

- Moving object creation into a dedicated factory class.
- Using abstract classes and inheritance.
- Understanding the **HAS-A relationship** between a store and its factory.
- Separating object creation from business logic.
- Writing code that depends on abstractions instead of concrete pizza classes.

---

### 📚 Part of My Design Patterns Learning Journey

This project is one of my practical C# implementations for understanding and applying Design Patterns.
