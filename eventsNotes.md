# Schedule - presentation on 2/17/2021 Morning!!!
-   first five groups, delegates actions events functions predicates will be delivering their presentation in the morning on friday
-   later on, the seralog and endlog groups will go
-   to include in presentation:
    1.  advantages of events
    1.  business use cases of delegates/events
    1.  general overview of events process

# Teamwork delegation!
-   Angela will be refactoring a previous Java project into C# for code demo purposes
-   Alex and Weston will be separating topics from the following article:
https://www.tutorialsteacher.com/csharp/csharp-event
-   Alex will be covering the first half of the topics.
-   Weston will cover "Passing an Event Data" and downwards


# Events
-  Events are the types of members that you can define in a class
-  They are a type of object that can notify other objects about some specific situation that has occurred with it or it's objects
-   a class can define an event on an action
-   Events are a simple and easy way for a class to notify others about a change in status
-   event model is built based on delegates
-   you use the event keyword to declare an event
- declaration is done in the following format:
    - [access modifier] [event] [event type] [event name]
    - event type is the delegate type of the event.
    - events follow the observer design pattern
-   the class that raises events is called the publisher, and the one who receives notifications of the event is called subscriber
-   an event is an encapsulated delegate

# how does an event work? Lifecycle
-   a class which contains the definition for the event is considered the "publisher", while any classes that subscribe to that event are "subscribers"
-   the delegate defines the signature for the event handler method of the subscriber class
-   an event handler signature must match in both the publisher and subscriber class
-   when an event is triggered, a response is sent from the publisher to the subscriber classes, at which point the designated event handlers in the subscriber classes handle events as needed
-   a publisher "delegates" events, while a subscriber "consumes" events

# how do you declare an event?
-   to declare an event, you use the following format:
    -   [access modifier] [event keyword "event"] [delegate name/event type] [event name]
-   the class containing the declared event is the publisher

# how do you raise an event?
-   to raise an event, you will want to invoke the event in a separate method within the publishing class. The method here serves as a wrapper to determine if the event should be invoked or not.
-   you can invoke an event by calling the "Invoke" method on your event reference variable.
-   to raise an event, declare the event(the event handler) in another class with the same signature as the initial event.
-   you will normally want to define this wrapper method with the protected and virtual modifiers so subscriber classes can redefine this method to handle the event as needed for their case.
-   in the case of a derived/child class, you will want to make sure that the base class onEvent method is called to ensure that the registered delegates receive the event

# how does a subscriber register an event?
-   A subscriber registers an event by creating a method with a matching signature to the original event
-   The subscriber will instantiate a new instance of the publisher class, and then use += operator to assign the event to a new event  method (the event handler)

# built-in event delegate types for event HANDLERS (not declarations)
-   .NET framework BCLs include delegate types EventHandler and EventHandler<T> for most common event handling
-   use EventHandler for any events that do not include event data
    - `public delegate void EventHandler(object sender, EventArgs e);`
- if an event uses event data, use the EventHandler<T> delegate
    - `public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);`



# Start on passing an Event Data


