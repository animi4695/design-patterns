Definition : 
    It is a Creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.
Why Singleton : 
    1) Lazy Loading - you don't have to initialize and create an object unless you're actually going to use it.
    2) Only Really need one instance : one example can be for a Database Connection in our application.

How to Singleton :
    1) Private Constructor
    2) private static instance of class
    3) static factory method for creation of instance

    Example we are going to see -> Weather station notifying the stations of current Weather and forecast conditions.
    References : 
        https://www.youtube.com/watch?v=FJlFbCKgT7Q
        https://www.interviewsansar.com/design-thread-safe-singleton-class-csharp-performance/
        https://www.dofactory.com/javascript/design-patterns/singleton
    