# INTENT

The intent of this pattern is to provide a surrogate or placeholder for another object to 
	control access to it

* Subject: defines the common interface between the RealSubject and the Proxy.
* RealSubject: defines the real object that the proxy presents.
* Proxy: provides an interface identical to the Subject. It maintains a reference
	to and controls access to the RealSubject.


# USE-CASES

* Use the pattern when you need to add some form of access control to an actual object

# CONSEQUENCES

+ It allows introducing new proxies without changing the client code: OCP
- Added complexity because of additional classes
- Performance impact of passing through additional layers







