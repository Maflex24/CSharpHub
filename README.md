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
