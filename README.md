\# Design Patterns in C# 💻



This repository documents my journey of learning and implementing \*\*Design Patterns using C#\*\*.



The goal is to understand how each pattern works, what problem it solves, and how to apply it through practical examples.



Each design pattern has its own folder containing the implementation and a README explaining the concept.



\## 📚 Implemented Design Patterns



\### 01 — Observer Pattern 👀



A Behavioral Design Pattern that allows multiple objects to be notified automatically when the state of another object changes.



I implemented the Observer Pattern using a \*\*YouTube channel notification system\*\*, exploring two approaches:



\- \*\*Push Model:\*\* The Subject sends updated data directly to its Observers.

\- \*\*Pull Model:\*\* Observers retrieve updated data from the Subject after receiving a notification.



📖 \*\*\[Read the explanation and explore the code](./ObserverPattern/)\*\*



\---



\### 02 — Decorator Pattern 🎁



A Structural Design Pattern that allows additional behavior to be added to objects dynamically by wrapping them with decorators, without modifying their original classes.



I implemented the Decorator Pattern using a \*\*gift customization system\*\*, where a basic teddy bear can be decorated with optional additions:



\- \*\*Gift Wrapping:\*\* Adds wrapping to the gift.

\- \*\*Ribbon:\*\* Adds a decorative ribbon.

\- \*\*Greeting Card:\*\* Adds a greeting card.



Each decorator wraps the previous object and adds its own cost and description.



This implementation demonstrates how to combine features dynamically while following the \*\*Open-Closed Principle\*\* and favoring \*\*composition over inheritance\*\*.



📖 \*\*\[Read the explanation and explore the code](./DecoratorPattern/)\*\*



\---



\### 03 — Strategy Pattern 🎮



A Behavioral Design Pattern that defines a family of algorithms, encapsulates each one, and makes them interchangeable.



I implemented the Strategy Pattern using a \*\*game character simulator\*\*, where different characters can use different attack strategies:



\- \*\*Sword Attack:\*\* Attacks using a sword.

\- \*\*Bow Attack:\*\* Attacks using a bow.

\- \*\*Magic Attack:\*\* Attacks using magic.



The application includes two characters, \*\*Warrior\*\* and \*\*Archer\*\*, each with a default attack behavior.



Using `SetAttackBehavior()`, a character can change its attack strategy dynamically at runtime without modifying its class.



This implementation demonstrates \*\*encapsulating what varies\*\*, \*\*programming to an interface\*\*, and favoring \*\*composition over inheritance\*\*.



📖 \*\*\[Read the explanation and explore the code](./StrategyPattern/)\*\*



\---



\### 04 — Simple Factory Pattern 🍕



A creational technique that encapsulates object creation in a separate factory class, allowing clients to request objects without directly instantiating concrete classes.



I implemented Simple Factory using a \*\*pizza ordering system\*\*, where customers can order different types of pizza:



\- \*\*Cheese Pizza:\*\* Created using `CheesePizza`.

\- \*\*Veggie Pizza:\*\* Created using `VeggiePizza`.



The `SimplePizzaFactory` class is responsible for creating the appropriate pizza based on the requested type.



The `PizzaStore` class receives the factory through its constructor and uses it to create, prepare, bake, cut, and box pizzas.



This implementation demonstrates \*\*encapsulation of object creation\*\*, \*\*separation of responsibilities\*\*, \*\*composition\*\*, and \*\*programming to abstractions\*\*.



📖 \*\*\[Read the explanation and explore the code](./SimpleFactoryPattern/)\*\*



\---



\### 05 — Factory Method Pattern 🏭



A Creational Design Pattern that defines a method for creating objects while allowing subclasses to decide which concrete class to instantiate.



I implemented the Factory Method Pattern using a \*\*pizza ordering system with different regional stores\*\*:



\- \*\*New York Pizza Store:\*\* Creates New York-style cheese pizza.

\- \*\*Chicago Pizza Store:\*\* Creates Chicago-style cheese pizza with square slices.



The abstract `PizzaStore` class defines the factory method `CreatePizza()` and provides a shared `OrderPizza()` process.



Each concrete store overrides `CreatePizza()` to instantiate its corresponding pizza type:



\- `NYPizzaStore` creates `NYCheesePizza`.

\- `ChicagoPizzaStore` creates `ChicagoCheesePizza`.



This implementation demonstrates \*\*inheritance\*\*, \*\*method overriding\*\*, \*\*runtime polymorphism\*\*, \*\*encapsulation of object creation\*\*, and the \*\*Dependency Inversion Principle\*\*.



Unlike Simple Factory, which uses a separate factory object, Factory Method delegates object creation to subclasses through inheritance.



📖 \*\*\[Read the explanation and explore the code](./FactoryMethodPattern/)\*\*



\---



\## 🛠️ Technologies



\- C#

\- .NET

\- Visual Studio

\- Git \& GitHub



\---



\## 🎯 Learning Goal



My goal is to build a deeper understanding of software design by implementing patterns myself instead of only studying their theory.



This repository will continue to grow as I learn and practice more Design Patterns. 🚀

