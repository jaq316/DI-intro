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

### Before DI

@[4-9, zoom-17](Notice all the "new" keywords?)

+++?code=samples/constructor.cs&lang=cs zoom-12

### After DI

---

## Why use Dependency Injection?

---

## The Dependency Injection Container

---

## Console app example

---

## Mocking

--- 

## Unit test example

---

## Payoffs of Dependency Injection


---

# Thank you!