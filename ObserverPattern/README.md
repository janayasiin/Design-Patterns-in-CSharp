# Observer Design Pattern 👀

## 📌 Overview

The **Observer Pattern** is a Behavioral Design Pattern that defines a **one-to-many relationship** between objects.

The idea is simple: when the state of one object (the **Subject**) changes, all its registered **Observers** are notified automatically.

The Subject doesn't need to know the specific details of each Observer. It only needs to know that the Observer implements a common interface.

## 🎬 Example: YouTube Channel

To understand this pattern, I implemented a simple YouTube notification system using C#.

Whenever a YouTube channel uploads a new video, all registered subscribers receive a notification.

### Main Components

- **`ISubject`** — Defines methods for registering, removing, and notifying observers.
- **`IObserver`** — Defines the method observers use to receive updates.
- **`YouTubeChannel`** — The Subject that manages subscribers and uploads videos.
- **`Subscriber`** — A regular observer that receives notifications.
- **`VIPSubscriber`** — Another observer type with its own notification behavior.

Subscribers can join or leave the channel at runtime, and only registered observers receive notifications.

---

## 📤 Push Model

In the **Push Model**, the Subject sends the updated information directly to its Observers.

When a new video is uploaded, the channel passes the video title to each registered subscriber:

```csharp
observer.Update(videoTitle);
```

The Observer receives the title directly without requesting it from the Subject.

**What I understood:** The Subject is responsible for sending the updated data to its Observers.

📁 **Implementation:** [ObserverPattern-Push](./ObserverPattern-Push/)

---

## 📥 Pull Model

In the **Pull Model**, the Subject notifies its Observers that something has changed without sending the updated information directly.

The channel calls:

```csharp
observer.Update();
```

Then each Observer retrieves the latest video title from the channel:

```csharp
channel.GetLatestVideoTitle();
```

**What I understood:** The Subject announces that an update happened, while each Observer is responsible for retrieving the information it needs.

📁 **Implementation:** [ObserverPattern-Pull](./ObserverPattern-Pull/)

---

## 🔍 Push vs. Pull

| Push Model 📤 | Pull Model 📥 |
|---|---|
| The Subject sends the updated data. | The Subject sends a notification. |
| `Update(videoTitle)` | `Update()` |
| Observers receive data directly. | Observers retrieve data from the Subject. |
| Useful when observers need the same information. | Useful when observers decide what information to retrieve. |

Both models implement the same Observer Pattern. The main difference is **how updated information reaches the Observers**.

---

## 🌱 What I Learned

By implementing both models, I learned:

- How one Subject can manage multiple Observers.
- How Observers can subscribe and unsubscribe dynamically.
- Why only registered Observers receive notifications.
- How different Observer types can react differently to the same event.
- The difference between sending data directly (**Push**) and retrieving it when needed (**Pull**).

The most important thing I learned is that the **Observer Pattern helps objects communicate while keeping them loosely coupled**.
