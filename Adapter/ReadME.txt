# INTENT

The intent of this pattern is to converts/wraps the interface of a callee object
into/according to the caller interface. Adapter lets classes work together
that couldn't otherwise because of incompatible interfaces.

* Variations: 
	Object Adapter Pattern: relies on composition 
	Class Adapter Pattern: relies on multiple inheritance

* Adaptee: defines an external system/object that needs to be adapted.
* Target: defines the domain-specific interface that the client uses.
* Client: collaborates with objects conforming to the Target interface.
* Adapter: implements the Taget interface


# USE-CASES

* When you want to use an existing class from incompatible external interface.
* When you want to create a reusable class (the adapter) that works with
	classes that don't have compatible interfaces
* When you need to use several existing subclasses, don't want create additional
	subclasses for each of them, but still need to adapt their interface

# CONSEQUENCES

+ A single adapter can work with many adaptees, and can add functionality
	to all adaptees at once
+ The interface (adapter code) is separated out from the rest of the code: SRP
+ New types of adapter can be introduced without breaking client code: OCP
- The object adapter makes it hard to override adaptee behaviour 
- Additional complexity is introduced




