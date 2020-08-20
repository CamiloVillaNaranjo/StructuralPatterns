# BridgeApp

## About this code

In the following code I use the approach where **devices** and **remote controls** are divided into its own hierarchies, so the _Remote_ will be the **bridge** between all _Devices_, if the Device is a TV the Remote will operate in certain manner, and if its a Radio should behave in differnt way.

## Bridge Pattern

This is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies (abstraction and implementation) which can be developed independently of each other.

## Pros & Cons

### Pros:

* You can create platform-independent classes and apps.
* The client code works with high-level abstractions. It isn't exposed to the platform details.
* _Open/Close Principle_. Yo can introduce new abstractions and implementations independently from each other.
* _Single Responsability Principle_. You can focus on high-level logic in the abstraction and on platform details in the implementation.

### Cons:

* You might make the code more complicated by applying the pattern to a highly cohesive class.
