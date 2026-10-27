\# Strategy Pattern - Game Character Simulator



\## Overview



This project demonstrates the \*\*Strategy Design Pattern\*\* using a game character simulator implemented in C#.



The application allows game characters to use different attack behaviors and change their attack strategy dynamically at runtime.



\## Design Pattern: Strategy



The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.



Instead of implementing attack behavior directly inside character classes, each attack type is implemented in a separate class.



\## Project Structure



| Class / Interface | Role |

|---|---|

| `IAttackBehavior` | Strategy Interface |

| `SwordAttack` | Concrete Strategy |

| `BowAttack` | Concrete Strategy |

| `MagicAttack` | Concrete Strategy |

| `GameCharacter` | Context |

| `Warrior` | Concrete Character |

| `Archer` | Concrete Character |

| `Program` | Client |



\## How It Works



1\. `IAttackBehavior` defines the `Attack()` method.

2\. Each concrete strategy implements a different attack behavior.

3\. `GameCharacter` holds a reference to `IAttackBehavior`.

4\. `PerformAttack()` delegates the attack to the current strategy.

5\. `SetAttackBehavior()` allows changing the attack strategy at runtime.



\## Example



```csharp

GameCharacter warrior = new Warrior();

GameCharacter archer = new Archer();



warrior.PerformAttack();

archer.PerformAttack();



warrior.SetAttackBehavior(new MagicAttack());

warrior.PerformAttack();

```



\## Output



```text

Attacking with a sword!

Attacking with a bow!

Attacking with magic!

```



\## Design Principles Applied



\### 1. Encapsulate What Varies



Attack behaviors are encapsulated in separate strategy classes.



\### 2. Program to an Interface, Not an Implementation



`GameCharacter` depends on the `IAttackBehavior` interface rather than a specific attack implementation.



\### 3. Favor Composition over Inheritance



Characters use attack behavior objects instead of inheriting attack implementations.



\### 4. Open/Closed Principle



New attack strategies can be added without modifying the existing `GameCharacter` class.



\## Key Benefit



The Strategy Pattern allows behaviors to be changed dynamically at runtime, making the application more flexible, reusable, and maintainable.

