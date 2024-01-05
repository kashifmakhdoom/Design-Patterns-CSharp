# INTENT

The intent of the singleton pattern is to ensure that a class only
has one instance, hence provide global access point to the clients.

# USE-CASES

* When there must be exactly one instance of the class, and it must be accessible
	to clients from a well-known access point.
* When the sole instance should be extensible by subclassing (protected keyword), 
	and clients should be able to use an extended instance without modifying
	their code

* Managing a database connection pool
* Caching frequently accessed data
* Managing application configuration settings
* General resource management

# CONSEQUENCES

+ Strict control over how and when clients access it - better than global variables.
+ Avoids polluting the namespace with global variables.
+ Subclassing allows configuring the application with an instance of the class
	you need at runtime.
+ Multiple instances can be allowed without having to alter the client

- Violates the Single Responsibility Principle (SRP) - (1) Object Creation (2) Object Lifecycle Management