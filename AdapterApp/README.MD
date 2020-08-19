# AdapterApp Project

## Adapter Pattern

Also known as Wrapper. Is a structural pattern that allows objects with incompatible interfaces to colaborate.

## Pros & Cons

### Pros:
* _Single Responsability Principle_. You can separate the interface or data conversions code from the primary business logic of the program.
* _Open/Closed Principle_. You can introduce new types of adapters into the program without breaking the existing client code, as long as they work with adapters through the client interface.

### Cons:
* The overall complexity of the code increase because you need to introduce a set of new interfaces and classes. Sometimes it's simplier just to change the service class so that it matches the rest of your code.'