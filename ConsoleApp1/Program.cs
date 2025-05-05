// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;





//hello weam

//string name="";
//Console.Write("Enter ur name: ");
//name=Console.ReadLine();
//Console.WriteLine("hi " +name);

///////////////////////////// if conditions"
//Console.Write ("Enter ur age: ");
//int age =int.Parse(Console.ReadLine());                          
//int age = Convert.ToInt32(Console.ReadLine());           // Convert the input to be int (from string to int)

//if (age <= 10)
//{
//    Console.WriteLine("You are eligible to vote!");
//}
//else if(age >=11 && age <=50) {
//    Console.WriteLine("hhhhhhhhhhh");
//}
//else
//{
//    Console.WriteLine("Sorry, you must be 18+ to vote.");
//}

//////////////////////////////////////////////////////////////////////////////

//Console.Write("Enter the temp: ");

////temp = Convert.ToInt32(Console.ReadLine());                        //convert from string to int 

//int temp;
//temp = 20;
//if (temp>0)
//{
//    if (temp < 15) { Console.WriteLine("cold day"); }
//    else if (temp>=15 && temp<25) { Console.WriteLine("the wheather is plesent"); }   
//    else { Console.WriteLine("its hot day"); }

//}
//else
//{
//    Console.WriteLine("its freeeeeeeeeeeeezing outside! ");
//}





//////////////////////////////////////////////////////////////// if conditions
//int a = 100;

///* check the boolean condition */
//if (a == 100)
//{
//    /* if condition is true then print the following */
//    Console.WriteLine("Value of a is 100");
//}
//else if (a == 20)
//{
//    /* if else if condition is true */
//    Console.WriteLine("Value of a is 20");
//}
//else if (a == 30)
//{
//    /* if else if condition is true  */
//    Console.WriteLine("Value of a is 30");
//}
//else
//{
//    /* if none of the conditions is true */
//    Console.WriteLine("None of the values is matching");
//}
//Console.WriteLine("Exact value of a is: {0}", a);

//Console.WriteLine("///////////////////////////// ");
//string[] obaaa = new string[] {"oba1","obaaaaa2","oaba3" };
//foreach (var item in obaaa)
//{
//    if (item.Length >= 5)
//    {
//        Console.WriteLine("ok");
//    }

//}


///////////////////////////////////////////////////////////////////////////////switch 
//char grade='B';
//switch (grade){

//    case 'a':Console.WriteLine("exellant");
//        break;
//    case 'B':
//        Console.WriteLine("very good");
//        break;
//    case 'c':
//        Console.WriteLine("good");
//        break;
//    case 'D':
//        Console.WriteLine("passed");
//        break;

//}






/////////////////////////////////////////////////////////////////////////for loooops"


//string[] students = { "weam", "bassant", "amany" };
//int[] numbers = new int[] { 9, 7, 6 };
//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}
//{

//}

//string[] fruits = new string[] { "aaa", "bbb", "sss" };
//for (int i = 0; i <fruits.Length ; i++)
//{
//    Console.WriteLine(fruits[i]);
//}



//////////////////////////////////////////////////////////////////////the while loop
//int count = 1;
//while (count <= 3)
//{
//    Console.WriteLine(count);

//    count++;
//}
//int n = 5, sum = 0, ii = 1;
//while (ii <= n)
//{
//    sum += ii;
//    ii++;
//}
//Console.WriteLine("sumis : "+ sum);





//static void greet( string name)
//{
//    Console.WriteLine("hello " + name);
//}

//greet("weam");
//Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");





//A aa = new A("aman");

//A a = new A();

//A.Print();


//public  class A
//{
//    public string Name { get; set; }

//    public A(string n )
//    {
//        Name = n;
//    }
//    public  static void Print()
//    {
//        Console.WriteLine("print");
//    }

//    public static void Print2()
//    {
//        Console.WriteLine("print 2222222");
//        Print();
//    }
//}






//Car mycar = new Car();
//mycar.Brand = "tesla";
//mycar.num = 66;
//Console.WriteLine(mycar.num);
//mycar.ShowBrand();
//mycar.secret();


//student obj=new student();
//obj.name = "alaa";
//obj.year = 7;
//obj.subjectNum = 4;
//obj.displayStudentInfo();

//////////////////////////////////////////////////////// <summary>
//encapsulation
/// </summary>
//BankAccount user = new BankAccount(100);
//user.deposit  (5);
//user.GetBalance();


//testing Clone - ref type::
//string name = "we";
//string n = name;

//Console.WriteLine($"name {name} ");
//Console.WriteLine($"n {n}");


//modify string

//Console.WriteLine("Modify string");
//name = "ttttt";
//Console.WriteLine($"name {name} ");
//Console.WriteLine($"n {n}");




//unsafe
//{


//    string original = "Hii, TutorialsPoint!";
//    string cloned = original.Clone().ToString();
//    // Get address of the first character in the heap
//    fixed (char* ptrP = original)
//    {
//        Console.WriteLine($"Heap Address ORIGINAL: {(ulong)ptrP:X}");
//        Console.WriteLine($"Value at heap: {*ptrP}"); // Should print 'h'
//    }

//    // Stack variable example
//    original = "WWWewwwwww";
//    fixed (char* ptrP2 = original)
//    {
//        Console.WriteLine($"Heap Address ORIGINAL: {(ulong)ptrP2:X}");
//        Console.WriteLine($"Value at heap: {*ptrP2}"); // Should print 'h'
//    }

//}


person p1 = new person("Sudhir Sharma", 27, "SEO01");
Console.WriteLine($"Name: {p1.name}, Age: {p1.age}, Employee ID: {p1.empid}");






SavingAccount mysavings = new SavingAccount(100m);
mysavings.AddIntersts(0.5m);
mysavings.GetBalance();

string[] array = {
    "hello",
    "from",
    "office" };

string message=string.Join(" ", array);
Console.WriteLine("Message: {0} ", message);

DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
Console.WriteLine("Message: {0}", chat);
string str = "fff";
foreach (char ch in str)
{
    Console.WriteLine(ch);
}
string str1 = "haaai";
string str2 = "kkk";

if (string.Compare(str1, str2) == 0)
{
    Console.WriteLine("equal");

}
else { Console.WriteLine("Not equal"); };
//classes
//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

public class BankAccount
{
    protected decimal balance;
    public BankAccount(decimal intial_balance)
    {
        if (intial_balance > 0)
        {
            balance = intial_balance;
        }

    }
    public void deposit(decimal amount)
    {
        if (amount > 0)
        { 
            balance += amount;
        }

    }
    public decimal GetBalance()
    {
        Console.WriteLine("the balance is : "+balance);
    return balance; }
}
public class SavingAccount : BankAccount
{
    public SavingAccount(decimal intial_balance) : base(intial_balance)
    {
    }
    public void AddIntersts(decimal interstRate) 
    {
        if (interstRate > 0) { 
        decimal intersts= interstRate*balance;
            balance += intersts;
                }
    
    }
}
/// <summary>
/// //////////////////////////////end class of capsulation
/// </summary>
/// 

public class Car
{
    public string Brand;
    public int num;
    public void ShowBrand()
    {
        Console.WriteLine("my car brand is "+Brand);
    }


    private int numberrr = 99999;
    public void secret()
    {
        Console.WriteLine("the scert nuber is :" + numberrr);

   }
}

public class student
{
    public string name;
    public int year;
    public int subjectNum;

    public void displayStudentInfo()
    {
        Console.WriteLine(name);
        Console.WriteLine(year);
        Console.WriteLine(subjectNum);
    }
}


struct person
{
    public string name;
    public int age;
    public string empid;

    public person(string name, int age, string empid)
    {
        this.name = name;
        this.age = age;

    }
}
