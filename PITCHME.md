# Dependency Injection

## An intoduction

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

---

## Different flavors of Dependency Injection

@ul
- Contructor Injection
- Property Injection
@ulend

+++

### Contructor Injection

A dependent class has a constructor, where all dependencies are set. They will be provided by the DI container

+++?code=samples/constructor.cs&lang=cs zoom-12

@[4-9, zoom-17](Constructor parameters provided by the DI container)

+++

### Property Injection

A dependent class have properties, where all dependencies are set.

+++?code=samples/property.cs&lang=cs zoom-12

@[3-8, zoom-17](Properties are set by the DI container)

---

## Interfaces & Classes

+++?code=samples/IGearLever.cs&lang=cs zoom-12

@[1-5, zoom-17](Interface: A contract or specification)

+++?code=samples/ManualGearLever.cs&lang=cs zoom-12

@[1-15, zoom-17](Concrete implementation of an interface)

+++

## Dependencies should be interfaces

@ul
- We want ***ALL*** of out dependencies to be based on an interface
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

## Why use Dependency Injection?

@ul
- Makes writing unit test code super easy. No complex setups! (Use mocks when unit testing)
- Promotes writing code where the services your code require can be **loosely coupled** with your code
@ulend

---

@snap[north span-100 ]
## The Dependency Injection Container
@snapend

@snap[midpoint span-100 text-06]
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
- When you need some service in a class, just add the interface to its constructor. The container will magically provide it.
- It is **AMAZING**!
@ulend
+++

## But how does the DI Container know what concrete types to provide?

@ul
- ### Registration!
- By registering a concrete type in the container, you tell the container how to instantiate the concrete type and what interface it services.
@ulend

---

## Console app example

### Coming soon!

---

## Mocking

### Coming soon!

--- 

## Unit test example

### Coming soon!

---

## Payoffs of Dependency Injection

@ul
- Infinitely easier unit testing of code
- Loosely coupled software
- Just ask for whatever services you want in the constuctor. Your DI container will deliver!
- As a consumer, you don't need to care about the lifetime of an object. It is taken care of on registration
- Swap out implementations of interfaces 
@ulend


---

# Questions?

---

# Thank you!