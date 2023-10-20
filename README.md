[![wakatime](https://wakatime.com/badge/github/etheoo98/Labb7-PolymorphismOOP.svg)](https://wakatime.com/badge/github/etheoo98/Labb7-PolymorphismOOP)

# Labb7-PolymorphismOOP
C# console application made for a beginners programming course.

## Assignment Description
In this assignment, you will practice using polymorphism in object-oriented programming. The assignment is mainly about designing a structure for polymorphism.

### What you need to do
- You need to create a class that will be the parent class for other classes that will inherit from it. The class should be called Geometry{} and it should have a method named Area(), with its return type being double.

- Create five classes that inherits from the Geometry class. These classes should be named Rectangle, Square, Circle, Parallelogram, and Ellipse. All these classes should have a method named Area().

- Every class should have at least one property, for example:
```
public class Circle
{
     public double Radius { get; set; }
}
```
- In all child classes, you will override the Area() method with different implementations, as the area for a circle is not calculated the same way as the area for a square.

- All child classes must have a constructor to assign values to the properties. We will provide a fixed value in the constructor. For example:
```
public Circle
{
      Radius = 4;
}
```
- In the Main() method, you should create an object reference from the Geometry class, and it should point to an object in each class.
