# INTENT

The intent of the factory method pattern is to define an interface for
creating an object, but to let subclasses decide which class to instantiate. 
Factory method lets a class defer instantiation to subclasses.

# USE-CASES

* When a class cannot anticipate the objects it must create.
* When a class wants its subclasses to specify the objects it creates.
* When classes delegate responsibility to one of several helper subclasses.
* As a way to enable reusing of existing objects.

# CONSEQUENCES

+ Loose Coupling: Factory methods eliminate the need to bind application-specific classes to your code
+ Open/Closed Principle: New types of products can be added without breaking client code
+ Single Responsibility Principle: Creating products is moved to one specific place in code, the creator

- Added Complexity: Clients might need to create subclasses of the creator class just to create a particular ConcreteProduct object.


