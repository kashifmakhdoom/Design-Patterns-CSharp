# INTENT

The intent of this pattern is to attach additional responsibilities to an object dynamically.
	A decorator thus provides a flexible alternative to subclassing for extending functionaly.

* Component: defines the interface for objects that can have responsibilities added to them dynamically
* ConcreteComponent: defines an object to which additional responsibilities can be attached
* Decorator: maintains a reference to a Component object, and defines an interface that confirms to 
	Component's interface
* ConcreteDecorator: adds responsbilities to the component


# USE-CASES

* When you have a need to add responsibilities to individual objects dynamically
	(at runtime) wihtout affecting other objects
* When you need to be able to withdraw responsibilities you attached to an object
* When extension by subclassing is impractical or impossible

# CONSEQUENCES

+ More flexible than using static inheritance via subclassing:
	responsibilities can be added and removed at runtime ad hoc
+ You can use the pattern to split feature-loaded classes until there's just one
	responsiblity left per class: SRP
- Increased effort is required to learn the system due to the amount of small,
	simple classes




