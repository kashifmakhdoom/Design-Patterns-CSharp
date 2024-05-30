# INTENT

The intent of this pattern is to use sharing to support large number of fine-grained
	objects efficiently. It does that by sharing parts of the state between these
	objects instead of keeping all that state in all of the objects.

* Flyweight: declares an interface through which they can receive and act on extrinsic state.
* Client: maintains a reference of Flyweights and computes or stores their extrinsic state.


# USE-CASES

* When the application use a large number of objects
* When storage costs are high because of the large amount of objects
* When most of the object state be made extrinsic
* When, if you remove extrinsic state, a large group of objects be
	replaced by relatively few shared objects
* When the application does not require object identity

# CONSEQUENCES

+ You may save a lot of memory when using the pattern for an applicable use case
- Processing costs might go up, but that's typically offsetted by the reduced storage costs
- The pattern is complex, which makes the code base more complicated as well








