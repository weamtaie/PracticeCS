// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;

///////////////////////ilist

IList<int> numbers=new List<int> { 1,2,3,4,5};
Console.WriteLine($"element os index 2 is :{numbers[2]}");

numbers.Add( 1 );
Console.WriteLine("Updated list:");
foreach (var num in numbers)
{
    Console.WriteLine(num);
}
numbers.Remove(5);
Console.WriteLine("---------------");
Console.WriteLine("Updated list:");
foreach (var num in numbers)
{
    Console.WriteLine(num);
}

////////////////////////////////Idictionary
Console.WriteLine("Idictionary id running");
IDictionary<string,int>Ages = new Dictionary<string,int>();
Ages.Add("weam", 23);
Ages.Add("weam222", 2333);

Console.WriteLine($"weams age is :{Ages["weam"]}");

Console.WriteLine("write ur search word :");
if (Ages.ContainsKey(Console.ReadLine()))
{
    Console.WriteLine("yes,its in the dic.");
}
else Console.WriteLine("its not in the dictionary");





////////////////////////////namespace
///

Console.WriteLine("---------------");
Console.WriteLine();    
firstPlace.place_class obj1=new firstPlace.place_class();
secondPlace.place_class obj2 = new secondPlace.place_class();

obj1.print();
obj2.print();
namespace firstPlace
{
    class place_class
    {
        public void print()
        {
            Console.WriteLine("helloz fron first nameSpace ");
        }
    }
}

namespace secondPlace
{
    class place_class
    {
        public void print()
        {
            Console.WriteLine("helloz fron second nameSpace ");
        }
    }
}