\# Decorator Pattern – C#



\## Overview



The Decorator Pattern is a structural design pattern that allows us to add new behavior to an object dynamically by wrapping it with decorator objects.



Instead of creating a separate subclass for every possible combination of features, we can combine decorators at runtime.



\## Example: Gift Customization 🎁



This project demonstrates the Decorator Pattern using a gift shop.



A customer starts with a teddy bear and can add optional decorations, such as gift wrapping, a ribbon, and a greeting card.



\## Project Structure



| Class | Role | Description |

|---|---|---|

| `Gift` | Abstract Component | Defines `GetDescription()` and `Cost()`. |

| `TeddyBear` | Concrete Component | Represents the basic gift, costing 50. |

| `GiftDecorator` | Abstract Decorator | Base class for all gift decorations. |

| `GiftWrapping` | Concrete Decorator | Adds gift wrapping for 5. |

| `Ribbon` | Concrete Decorator | Adds a ribbon for 3. |

| `GreetingCard` | Concrete Decorator | Adds a greeting card for 2. |



\## Example Usage



```csharp

Gift myGift = new TeddyBear();



myGift = new GiftWrapping(myGift);

myGift = new Ribbon(myGift);

myGift = new GreetingCard(myGift);



Console.WriteLine(myGift.GetDescription());

Console.WriteLine(myGift.Cost());

```



\## Output



```text

Teddy Bear, Gift Wrapping, Ribbon, Greeting Card

60

```



\## How It Works



Each decorator inherits from `GiftDecorator` and stores a reference to a `Gift` object.



When `Cost()` is called, the decorator adds its own price to the cost of the wrapped gift.



For example, the final object structure is:



```text

GreetingCard

&#x20;   └── Ribbon

&#x20;         └── GiftWrapping

&#x20;               └── TeddyBear

```



The total cost is:



`2 + 3 + 5 + 50 = 60`



\## Design Principles



\- \*\*Open-Closed Principle:\*\* New decorations can be added without modifying existing classes.

\- \*\*Favor Composition Over Inheritance:\*\* Each decorator holds a reference to the object it wraps.

\- \*\*Program to an Abstraction:\*\* Decorators depend on the abstract `Gift` type rather than a specific gift class.



\## Key Takeaway



The Decorator Pattern allows us to combine optional features dynamically while keeping the original component unchanged.

