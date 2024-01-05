# INTENT

The intent of the abstract factory pattern is to define an interface for
creating families of related or dependent objects without specifying their
concrete classes.

# USE-CASES

* When a system should be independent of how its products are created,
	composed, and represented
* When you want to provide a class library of products and you only
	want to reveal their interfaces, not their implementations
* When a system should be configured with on of multiple families of products
* When a family of related product objects is designed to be used together
	and you want to enforce this constraint

* Support multiple language - English, French, etc.
* Converting documents to different formats - PDF, DOCX etc.
* Abstracting away a database layer - SQL or NoSQL
* Supporting different application themes or styles

# CONSEQUENCES

+ Loose Coupling: Isolates concrete classes, because it encapsulates 
	the responsibility and the process of creating product objects
+ Open/Closed Principle: New products can easily be introduced wihtout breaking
	client code
+ Single responsibility Principle: Code to create products is contained in one place
+ Makes exchanging product families easy
+ Promotes consistency among products

- Supporting new kind of products is rather difficult


