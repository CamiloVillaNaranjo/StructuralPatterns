# DecoratorApp

## About this code

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