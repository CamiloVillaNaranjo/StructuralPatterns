# CompositeApp Project

## About this code

In this I will cover a Product scenario were exists Products that are treated as Compositions. For example a **Desktop PC gamer**, is a product, but it is Compound by:
* CPU tower.
* Monitor.
* Mouse.
* Keyboard.

And also **CPU tower** is compund by:
* RAM.
* Mother Board.
* Video Card.
* Network card (or Wireless card).

Where all of them have a price, individually and in PC bundle

## Composite Pattern

This pattern let us **compose** objects into __tree structures__ and then work with these structures as if they were individual objects.

## Pros and Cons

### Pros

* You can work with complex tree structures more conveniently: use polymorphism and recursion to your advantage.
* Open/Closed Principle. You can introduce new element types into the app without breaking the existing code, which now works with the object tree.

### Cons
* It might be difficult to provide a common interface for classes whose functionality differs too much. In certain scenarios, you'd need to overgeneralize the component interface, making it harder to comprenhend.