To create a new project in .NET core please follow the following steps.
-------------------------------------------------------------------------
1. Create a solution sln file
    cmd: dotnet new sln --name CsharpFundamental
2. Create a new Project of type console.
    cmd: dotnet new console --name GradeBook
3. add the project to the solution
    cmd: dotnet sln CsharpFundamental.sln add Gradebook\Gradebook.csproj.
4.the same way u can add "n" number of projects to the solution.
--------------------------------------------------------------------------
Dotnet restore  -- reads the csproj file and gets the external  dependency from Nuget, Nuget is a package manager.
dotnet build    -- this command reads the source code and then converts into binary formate. combines all the cs files and generate a single dll(Binary formate of my source code).

if u want to pass any parameter to the application the syntax is below.
 dotnet run --parameter 

 example of first .net app: save this as.cs file
-----------------------------------------------------------------------------------------------------------------------
 using System;

 namespace GradeBook
 {
     class Program
     {
         static void Main(string[] args)
         {
             if(args.Lenght > 0)
             {
                 //This notation below is called the interpolation.
                 Console.WriteLine($"Welcome {args[0]}, You are a Asshole if you miss this language Syntax (lol)");
             }
         }
     }
 }
 ------------------------------------------------------------------------------------------------------------------------
 execute this dotnet run --yeswanth
 O/P: Welcome yeswanth, You are a Asshole if you miss this language Syntax (lol)
 ------------------------------------------------------------------------------------------------------------------------
Deceleration of array 
var numbers =new double[3]{10.2,23.4,24.3};
array has some limitation so we use some data structures like Stack and Ques we will start with simple DS call List.

List implementation:

List: Is present in the name space System.Collections.Generic;
List<double> grade=new List<double>() {12.7,10.3,5.6};
and also we can add the values dynamically as they are stretchable in size.
grade.Add(12.3);
Getting Value from List
grade[0];
O/P: 12.7
--------------------------------------------------------------------------------------------------------------------------
Class in C# - C# is a Object oriented programing language.

def: Class is a blue print, It defines how i am going to build the objects. we instantiate a class to create a object.
-------------------------------------------------------------------------------------------------------------------------------
static and non static:

Static is the property of function that is related to a class and non static is the property or function belongs to a objet instance.
-------------------------------------------------------------------------------------------------------------------------------
Reference type and value types:

Reference Type                                                                                  Value type
ex: var b=new Book("Yeswanth");                                                                 ex:var x=3;
1.Reference types hold's the pointer or the address in which the object is stored.              1. where as in value type it hold's the value it self.
2.Variable that hold's a reference                                                              2. Variable that hold's the value
3.all classes are reference type                                                               3.all struct are value type






By default Parameters are passed by value. In case if u want to pass a reference just keep ref before that.

working with value type:
----------------------------------------------------------------------------------------------------------------------------
jumping statement :

break: use to skip the look, and terminate the look if it hits this line of code.
continue: just skip the lines below the loop and just continue with the loop again
goto: allow the use to to skip and go to the statement where it's labeled.
----------------------------------------------------------------------------------------------------------------------------
Switch Statement:
switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                 AddGrade(70);
                    break;
                case 'D':
                 AddGrade(60);
                    break;
                default:
                AddGrade(0);
                    break;
            }

Pattern Matching in C#: this is a character of C# 7
-------------------------------------------------------------------------------------------
 Property:
//Auto Implementation.
 public string Name
 {
     get;
     set;
 }
 //This is a implementation property; this helps to have a full control on my property.
  public string Name
 {
     //This will get executed when we try to initialize a property.(or) read a property.
     get
     {
        return "Krithvika";
     }
     set
     {
         if(!String.IsnullOrEmpty(value))
        name = value;
     }
 }
//Private field
 private string name;

 //ReadOnly and const

 readonly   : can be changed at the time or creation or at any constructor.
 const      : Only at a time of initialization. they are like static member's of the class.


 //Events and Delegates:
 Events are build on Delegates.
 Delegate: is a variable that matches the Method signature. Please the example in test. "Chech_delegate_canInvoke_otherMethod"