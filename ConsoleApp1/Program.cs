// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


Console.WriteLine("-----------");
Console.WriteLine();

Dog Mydog=new Dog();
Mydog.MakeSound();

Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();

DataPrint dataPrint = new DataPrint();
dataPrint.print(2);
dataPrint.print("hi 2");
dataPrint.print(2.2);


Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();

Point a = new Point(1,2);
Point b = new Point(2,3);

Point c = a + b;
Console.WriteLine($"the result is :{c}");

Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();

Rectangle r = new Rectangle(10, 7);
int RecArea=r.area();
Console.WriteLine($"Rectangle class area :{ RecArea}");

Triangle t = new Triangle(10, 5);
int TraiArea = t.area();
Console.WriteLine($"traingle class area :{TraiArea}");

Shape sh = new Shape();

Caller c1 =new Caller();
Caller.CallArea(sh);

Caller.CallArea(t);
Caller.CallArea(r);
c1.Print();


Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine();

IAnimal animal;
animal=new Lion();
animal.MakeSound();


animal = new Cat();
animal.MakeSound();
//class


//abstract class Animal
//{
//    public abstract void MakeSound();  // No implementation
//}

//class Dog : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Dog barks.");
//    }
//}




//Runtime polymorphism (Method Overriding)
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

//Function Overloading
class DataPrint
{
    public void print(int i)
    {
        Console.WriteLine(i);    
    }
    public void print(double f)
    {
        Console.WriteLine(f);
    }
    public void print(string s)
    {
        Console.WriteLine(s);
    }
}

class Point
{
    private int X;
    private int Y; 

    public Point (int x, int y)
    {
        X = x;  
        Y = y;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point((p1.X+ p1.Y),(p2.X+p2.Y));
    }
    //The ToString() method is
    //a function (or method)
    //designed to return a string
    //representation of an object.
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}


////////////////////////////////////////////////
public class Shape {
protected int width, height;

public Shape(int a = 0, int b = 0)
{
    width = a;
    height = b;
}
public virtual int area()
{
    Console.WriteLine("Parent class area :");
    return 0;
}
   }
   class Rectangle : Shape
{
    public Rectangle(int a = 0, int b = 0) : base(a, b)
    {

    }
    public override int area()
    {
        
        return (width * height);
    }
}
class Triangle : Shape
{
    public Triangle(int a = 0, int b = 0) : base(a, b)
    {
    }
    public override int area()
    {
        
        return (width * height / 2);
    }
}
public class Caller
{
 
    public void Print()
    {
        Console.WriteLine("vvv");
    }
    public static void CallArea(Shape sh)
    {
        int a;
        a = sh.area();
        Console.WriteLine("Area: {0}", a);
    }
}


public interface IAnimal
{
    void MakeSound();
    
}
public class Lion:IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("lion make sound");
    }
}
public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Cat make sound");
    }
}