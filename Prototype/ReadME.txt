# INTENT

The intent of this pattern is to specify the kinds of objects to create
using a prototypical instance and create new objects by copying this 
prototype.

* Prototype: declares an interface for cloning itself.
* ConcretePrototype: implements an operation for clonning itself.
* Client: creates a new object by asking a Prototype to clone itself.


# USE-CASES

* When a system should be independent of how its objects are created,
	and to avoid building a set of factories that mimics the class
	hierarchy.
* When as system should be independent of how its objects are created,
	and when instances of a class can have one of only a few different
	combinations of states.

* Document cloning in word processors
* Managing configuration instances
* Creating reusable UI components

# CONSEQUENCES

+ Prototype hides the ConcreteProduct classes from the client,
	which reduces what the client needs to know
+ Reduced subclassing.
- Each implementation of the prototype base class must implement
	its own clone method.


