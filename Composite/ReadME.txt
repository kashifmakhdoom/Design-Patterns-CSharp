# INTENT

The intent of this pattern is to compose objects into tree structures to represent part-whole hierarchies. 
	as such, it lets clients treat individual objects and compositions of objects uniformly: as if they
	all were individual objects.

* Component: declares the interface for objects on the compositions, and contains a common operation
* Leaf: represents leaf objects in the composition, and has no children. It defines behaviour for
	primitive objects in the composition.
* Composite: stores child components and defines behaviour for components having children
* Client: manipulates objects in the compositions through the Component interface.


# USE-CASES

* When you want to represent part-whole hierarchies of objects
* When you want to be able to ignore the difference between compositions of objects and individual objects

# CONSEQUENCES

+ Makes the client simple
+ It's easy to add new kinds of components: OCP

- It can make the overall system too generic





