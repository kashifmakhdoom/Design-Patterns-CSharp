# INTENT

The intent of this pattern is to decouple an abstraction from its implementation
so the two can vary independently

* Abstraction: defines the abstraction's interface and holds a reference to the implementor
* RefinedAbstraction: extends the interface defined by Abstraction
* Implementor: defines the interface for implementation classes
* ConcreteImplementor: implements the Implementor interface and defines its concrete implementation


# USE-CASES

* When you want to avoid a permanent binding between an abstraction and its implementation
	(to enable switching implementations at runtime)
* When abstraction and implementations should be extensible by subclassing
* When you don't want changes in the implementation of an abstraction have an impact on the client.

# CONSEQUENCES

+ Docoupling: the implementation isn't permanently bound to the abstraction
+ As the abstraction and implementation hierarchies can evolve independently,
	new onces can be introduced as such: OCP
+ You can focus on high-level logic in the abstraction, and on the details in the 
	implemenation: SRP
+ You can hide implementation detaisl away from clients

- The object adapter makes it hard to override adaptee behaviour 
- Additional complexity is introduced




