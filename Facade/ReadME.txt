# INTENT

The intent of this pattern is to provide a unified interface to a set of interfaces in a subsystem.
	It defines a higher-level interface that makes the subsystem easier to use

* Facade: knows which subsystem classes are responsible for a request, and delegates client
	requests to appropriate subsystem objects
* Subsystem Class: each subsystem class implements a single independent functionality.
	They don't know about the Facade, but they do handle work assigned by it.


# USE-CASES

* When you want to provide a simple interface into a complex subsytem
* When there are many dependencies between a client and the implementation
	classes of the abstraction

# CONSEQUENCES

+ Reduce the complexity to deal with multiple subsystems
+ Promotes loose coupling between the subsystem and its clients: OCP
+ Clients are not forbidden to use subsystem classes





