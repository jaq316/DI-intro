---?image=assets/img/intro.jpeg

## Dependency Injection

### An intoduction

---

## What is Dependency Injection?

+++

## What is a dependency?

+++

### Merriam-Webster Dictionary
> something that is dependent on something else

+++

## What is a dependency injection?

+++

### Wikipedia
> In software engineering, dependency injection is a technique whereby one object supplies the dependencies of another object. 
> A "dependency" is an object that can be used, for example as a service. Instead of a client specifying which service it will use, something tells the client what service to use.

+++

![It's a dependency](/assets/img/its-a-dependency.jpeg)

---

## Different flavors of Dependency Injection

@ul
- Contructor injection
- Setter injection (aka Property injection)
- Interface injection
@ulend

+++

### Contructor Injection

The dependencies are provided through a class constructor

+++?code=samples/constructor.cs&lang=cs zoom-12

@[4-9, zoom-17](Constructor parameters provided by the DI container)

+++

### Setter Injection

The client exposes a setter method that the DI container uses to inject the dependency

+++?code=samples/property.cs&lang=cs zoom-12

@[3-8, zoom-17](Properties are set by the DI container)

+++

### Interface injection

The dependency provides an injector method that will inject the dependency into any client passed to it. Clients must implement an interface that exposes a setter method that accepts the dependency.

*Very rarely seen in the wild*

---

## Dependency injection's responsibilities

@ol

1. Create the objects
2. Know which classes require those objects
3. And provide them all those objects

@olend

+++
## Dependency injection's responsibilities

If there is any change in objects, then DI looks into it and it should not concern the class using those objects. This way if the objects change in the future, then its DI’s responsibility to provide the appropriate objects to the class.

---

## Interfaces & Classes

+++?code=samples/IGearLever.cs&lang=cs zoom-12

@[1-5, zoom-17](Interface: A contract or specification)

+++?code=samples/ManualGearLever.cs&lang=cs zoom-12

@[1-15, zoom-17](Concrete implementation of an interface)

+++

## Dependencies should be interfaces

@ul
- We want ***ALL*** of our dependencies to be based on an interface
- Any service code you write should have an interface
- Other classes in your app will rely only on the interface and not the concrete implementation of the interface
@ulend

--- 

## What Dependency Injection looks like

+++?code=samples/constructor-before-di.cs&lang=cs zoom-12

@[4-9, zoom-17](Notice all the "new" keywords?)

### Before DI

+++?code=samples/constructor.cs&lang=cs zoom-12

### After DI

---

@snap[north span-100 ]
## The Dependency Injection Container
@snapend

@snap[south span-100 text-08]
@ul
- The container is the very heart of your DI implementation
- Interfaces are mapped to concrete types so that the container can provide the correct implementation when an interface is required
- Containers typically allow you to specify the "lifetime" of any object it knows about (Singleton, one instance per request, etc.)
- The container is the thing that will new up all of your dependencies as they are needed
@ulend
@snapend


+++

# DI Magic

@ul
- When you need some service in a class, just add the interface to its constructor. The container will "magically" provide it.
- It is **AMAZING**!
@ulend
+++

## But how does the DI Container know what concrete types to provide?

@ul
- ### Registration!
- By registering a concrete type in the container, you tell the container how to instantiate the concrete type and what interface it services.
@ulend

---

## Benefits of using DI

@ul
- Infinitely easier unit testing of code
- Boiler plate code is reduced, as initializing of dependencies is done by the injector component.
- Helps to enable loose coupling
- Extending the application becomes easier
- Swap out implementations of interfaces 
@ulend

+++

## Disadvantages of DI

@ul
- It’s a bit complex to learn, and if overused can lead to management issues and other problems.
- Many compile time errors are pushed to run-time.
- Dependency injection frameworks are implemented with reflection or dynamic programming. This can hinder use of IDE automation, such as "find references", "show call hierarchy" and safe refactoring.
@ulend

---

# Questions?

---

@snap[north span-100]
# Thank you!
@snapend

@snap[south-west span-30]
![GitHub](/assets/img/github-qr.png)
@snapend

@snap[south-east span-30]
![GitPitch](/assets/img/gitpitch-qr.png)
@snapend