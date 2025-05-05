// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Security;

//eNUM bRANCH 

Console.WriteLine("WELCOME ENUM");

int weekStart = (int)Days.Mon;
int weekEnd =(int)Days.Fri;


Console.WriteLine("/////////////////////////////////////////////////////////");
Console.WriteLine();

Days day =Days.tue;
switch (day)
{
    case Days.Mon:
        Console.WriteLine("its mon");
        break;
    case Days.tue:
        Console.WriteLine("its tue");
        break;
    case Days.Wed:
        Console.WriteLine("its wed");
        break;
}

Console.WriteLine("/////////////////////////////////////////////////////////");
Console.WriteLine();

Console.WriteLine($"monday  {weekStart}");
Console.WriteLine($"friday {weekEnd}");


Console.WriteLine("/////////////////////////////////////////////////////////");
Console.WriteLine();

StatusCode status=StatusCode.NotFound;
Console.WriteLine("the status is :"+status);
Console.WriteLine("the code of the status :" +(int)status);



Console.WriteLine("/////////////////////////////////////////////////////////");
Console.WriteLine();

Permissions userPermissions = Permissions.read|Permissions.write;

Console.WriteLine($"user permission : {userPermissions}");
Console.WriteLine($"Do you have write permission?{userPermissions.HasFlag(Permissions.write)}");
Console.WriteLine($"Do you have write permission?{userPermissions.HasFlag(Permissions.excute)}");


Console.WriteLine("/////////////////////////////////////////////////////////");
Console.WriteLine();


string input = "write";
Permissions statusFromString = (Permissions)Enum.Parse(typeof(Permissions), input);
Console.WriteLine($"Converted from string: {statusFromString}");

int value = 2;
Permissions statusFromInt = (Permissions)value;
Console.WriteLine($"Converted from integer: {statusFromInt}");




//classes
//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };
enum StatusCode
{
    Success = 200,
    NotFound = 404,
    ServerError = 500
}

[Flags]
enum Permissions
{
    none=0,
    write=1,
    read=2,
    excute=8,
    fullcountroll= write| read| excute,

}