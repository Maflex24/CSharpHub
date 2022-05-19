# Object programming paradigms

## Encapsulation
Protect sensitive data, or data which not should be allowed to change by using `private`, or `protected` access modifier.  
`protected` means, that method/field/property is not accessable from outside the class, but is as `private` in class which inherit current class. So both classes have access to this value.  
  
We can use `getter`, and `setter` public methods with some conditions to get access to private value.  
We can also use `properties`, like:
```cs
public int Age { get; private set; }
```  
At this situation I can get value of "Age", but I can't modify it outside of class. We can probably set age inside class based on date of birth, so it will be bad solution to change it outside.

## Inheritance
Classes can inherit properties, values, methods from another, more general class, like class Student inherit from class Person. Features can be extended, shared.  
Basic class `abstract` doesn't allowed to create their instance.  
Mark method `virtual` allows to `override` it in inherited class  
  

## Polymorphism  
 Class which inherit from another class can have the same methods, but this methods can behave in another way. Like Person method Hello() can output "Hello! I'm a person". Student class inherit from Person can output "Hello! I'm a student!".  
   
## Abstraction 
Objects are abstracts model. They do there job, but without sharing details. Like "WidhrawMoney(value)", from user perspective it's just give him money, but really it's first check is enough money on account, change value of account money and more. 

# SOLID
It's five rules of programming. It's good practices to keep code more clean, how to create classes and dependencies between them.  
  
## Single Resposibility  
Every class should only have one reason to change. So it has only one responsibility (have object structure, print information about object, or save object fo file)
	
## Open-Close Principle
Every class should be open for extension, but close to modification.
	
## Liskov Substitution Principle
Inherited classes must have all behavior of basic class. If I call the same function on every inherited class it must work correctly. For example class Duck can have function Fly(), but if we inherited Duck class in RubberDuck, there is a problem. RubberDucks don't fly! So better do basic class like FlyingDuck.
	
## Interface Segregation Principle
Some general interfaces will not be valid for all classes which implemented this interface. Interfaces can want implement functionality, which current class not have. This is why is better to create more, smaller interfaces, more focused on specific functionalities. 
	
## Dependency Inversion Principle
High level modules should not depend on low level modules; both should depend on abstractions.