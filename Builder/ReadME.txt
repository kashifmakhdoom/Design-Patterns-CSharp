# INTENT

The intent of the builder pattern is to separate the construction of a
complex object from its representation. By doing so, the same construction
process can create different representations.

* Builder: specifies an abstract interface for creating parts of a
	Product object
* ConcreteBuilder: constructs and assembles parts of the Product
	by implementation the Builder interface
* Product: represents the complex object under construction
* Director: constructs an object by using the Builder interface

# USE-CASES

* When you want to make the algorithm for creating a complex object
	independent of the parts that make up the object and how 
	they're assembled.
* When you want to construction process to allow different
	representations for the object that's constructed

* Generating documents
* Building a database query
* Creating a game character
* Constructing a UI or form or layout - HtmlBuilder for example

# CONSEQUENCES

+ Encapsulation: It lets us vary a products' internal representation
+ Single Responsibility Principle: It isolates code for construction
	and representation; it thus improves modularity by encapsulating
	the way a complex object is constructed and represented
+ It gives us finer control over the complex construction process

- Increased complexity of code base


