# DecoratorApp

## About this code
 
Imagine that you have an application for notify message via email, so I have a class **Notifier** to do that, but with the time clients also wants to send their messages via slack or facebook or SMS or combining those, here is when I use the __decorator__ to decorate the way that all of these platforms send messages.

## Decorator Pattern

Let us attach new behaviors to objects by placing these objects inside special wrapper objects that contains the behaviors.

## Pros and Cons

### Pros

* You can extend an object's behavior without making a new subclass.
* You can add or remove responsbilities from an object at runtime.
* You can combine several behaviors by wrapping an object into multiple decorators.
* _Single Responsability Principle_. You can devide a monolitic class that implements many possible variants of behavior into several smaller classes.

### Cons

* It is hard to remove a specific wrapper from the wrappers stack.
* It is hard to implement a decorator in such a way that its behavior does not depend on the order in the decorators stack.
* The initial configuration code of Layers might look pretty ugly.