This is a small example for Dependency Injection.

In this case a client is doing something (dosn't matter what it exactly does).
We like to implement some logging for the client. But what kind of logging we like to use shouldn't be decided via the client.

At this point Dependency Injection comes into play. The client just inherit a LoggerInterface. The actual outgrowth for the logging will be set via the constructor from outside. 
