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