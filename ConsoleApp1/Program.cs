// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


Console.WriteLine("the parent class /////////////////////");
Console.WriteLine();
rectangler rec = new rectangler();
rec.setlength(10);
rec.setwidth(10);
rec.setbread(10);



double volume=rec.getvolume();
Console.WriteLine(volume);

Console.WriteLine();    
Console.WriteLine("the inhertied class /////////////////////");
Console.WriteLine();

tableTop t = new tableTop();
t.setlength(10);
t.setwidth(10);
t.setbread(10);
Console.WriteLine($"the volume of the rectanglar itself is: {t.getvolume()}");
t.display();


Console.WriteLine();
Console.WriteLine("/////////////////////");
Console.WriteLine();

Student stud=new Student("weam",25);
stud.Display();




Console.WriteLine();
Console.WriteLine("/////////////////////");
Console.WriteLine();
StaticVar s1 = new StaticVar();
StaticVar s2 = new StaticVar();

Console.WriteLine(s1.getNum());//0
s1.count();
Console.WriteLine(s1.getNum());//1
s1.count();
Console.WriteLine(s1.getNum());//2
s1.count();//3


s2.count();//4
s2.count();//5
s2.count();//6

Console.WriteLine("Variable num for s1: {0}", s1.getNum());
Console.WriteLine("Variable num for s2: {0}", s2.getNum());



Console.WriteLine();
Console.WriteLine("/////////////////////");
Console.WriteLine();

Dog Mydog=new Dog();
Mydog.MakeSound(); 


//class

class rectangler
{
    private double length;
    private double height;
    private double breadth;
    public double volume;

    public rectangler ()
    {
        Console.WriteLine("the project created");
    }
    ~rectangler()
    {
        Console.WriteLine("the project deleted");

    }
    public void setlength(double len)
    {
        length = len;
       
    }
    public void setwidth(double he)
    {
        height = he;

    }
    public void setbread(double bread)
    {
        breadth = bread;

    }
    public double getvolume() {
        volume =length *breadth *height;
        return volume;

    }

}


class tableTop : rectangler
{
    private double cost;

    public double getcost()
    {
        
        cost = getvolume() * 70;
        return cost;
    }
    public void display()
    {
        Console.WriteLine($"the cost is :{getcost()}");
    }
}
class StaticVar
{
    public static int num;

    public void count()
    {
        num++;
    }
    public int getNum()
    {
        return num;
    }
}


class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
}
class Student : Person
    {
        public int RollNo;

public Student(string name, int rollNo):base(name)
{
            RollNo = rollNo;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Roll No: {RollNo}");
        }
}


abstract class Animal
{
    public abstract void MakeSound();  // No implementation
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }
}