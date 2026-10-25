\# Observer Design Pattern 👀



\## 📌 Overview



The \*\*Observer Pattern\*\* is a Behavioral Design Pattern that defines a \*\*one-to-many relationship\*\* between objects.



The idea is that when one object (the \*\*Subject\*\*) changes, all its registered \*\*Observers\*\* are notified automatically.



The Subject doesn't need to know the details of each Observer. It only needs to know that the Observer implements a common interface.



\## 🎬 Example: YouTube Channel



To understand this pattern, I implemented a simple YouTube notification system using C#.



The idea is simple: when a YouTube channel uploads a new video, everyone subscribed to that channel receives a notification.



\### Main Components



\- \*\*`ISubject`\*\* — Defines methods for registering, removing, and notifying observers.

\- \*\*`IObserver`\*\* — Defines the method observers use to receive updates.

\- \*\*`YouTubeChannel`\*\* — The Subject that manages subscribers and uploads videos.

\- \*\*`Subscriber`\*\* — A regular observer that receives notifications.

\- \*\*`VIPSubscriber`\*\* — Another observer type with its own notification behavior.



The implementation also supports subscribing and unsubscribing at runtime. Only currently registered observers receive notifications.



\---



\## 📤 Push Model



In the \*\*Push Model\*\*, the Subject sends the updated information directly to its Observers.



When a new video is uploaded, the channel sends the video title to every registered subscriber:



```csharp

observer.Update(videoTitle);

```



The Observer receives the title directly without asking the Subject for it.



\*\*What I understood:\*\* The Subject is responsible for sending the data that Observers need.



📁 \*\*Code:\*\* \[ObserverPattern-Push](./ObserverPattern-Push/)



\---



\## 📥 Pull Model



In the \*\*Pull Model\*\*, the Subject notifies its Observers that something has changed, but doesn't send the updated data directly.



The channel calls:



```csharp

observer.Update();

```



Then each Observer requests the latest video title from the channel:



```csharp

channel.GetLatestVideoTitle();

```



\*\*What I understood:\*\* The Subject announces that an update happened, while each Observer retrieves the information it needs.



📁 \*\*Code:\*\* \[ObserverPattern-Pull](./ObserverPattern-Pull/)



\---



\## 🔍 Push vs. Pull



| Push Model 📤 | Pull Model 📥 |

|---|---|

| Subject sends the updated data | Subject sends a notification |

| `Update(videoTitle)` | `Update()` |

| Observer receives data directly | Observer requests data from the Subject |

| Useful when observers need the same information | Useful when observers choose what information to retrieve |



Both models implement the same Observer Pattern. The main difference is \*\*how the updated information reaches the Observers\*\*.



\---



\## 🌱 What I Learned



By implementing both models, I learned:



\- How one Subject can manage multiple Observers.

\- How Observers can subscribe and unsubscribe dynamically.

\- Why only registered Observers receive notifications.

\- How different Observer types can react differently to the same event.

\- The difference between sending data directly (\*\*Push\*\*) and requesting

