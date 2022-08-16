#region 
//The "#region" can be used to 'collapse' areas of code so you can focus on the key areas
//Comments can be done in a couple different ways, after // and multiline between /* comment */
/*
multi
line
comment
*/

//All of these functionalities is for the programmers, the compiler deletes them when creating the executable (.exe)
//Programmers can use them to document their code and help future programmers understand their thinking.
#endregion

#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion

Console.Title = "TES Hansenberg";

#region Variables
Console.WriteLine("Are you ready to start your adventure?");

string answer = Console.ReadLine();

bool AdventureStart = false;
if(answer == "Yes"){
    AdventureStart = true;
}

if(AdventureStart == true){
Console.WriteLine("Create your character.");
Console.WriteLine("What is your name?");

string myString = "This is how to define a string variable!";

myString = Console.ReadLine();

Console.WriteLine("Welcome " + myString + ", you sound strong!");

Console.WriteLine("Choose your race...\n-Human\n-Elf\n-Orc\n-Dwarf\n-Wolfman");
Console.ReadLine();

string myString2 = "This is how to define a string variable!";

myString2 = Console.ReadLine();
Console.WriteLine("Where are you from " + myString2 + "?");
}
/*
* The four main basic types we we will work with in the beginning are:
* bool, Int, Float and String   
* bool or boolean, can only be 'true' or 'false'
* Int, or integer, is a whole number; 1, 2, 3
* Float is a decimal number; 3.14 or 7.777
* Strings is just text found between quotationmarks "This is a string, easy right?"
*
* Programmers use these different types to better communicate their thoughts and optimize the program
* C# have, at the time of writing; 10 different types of numbers, choosing the right ones can be key to your objective.
*
* There are many different data types which can be explored in the Microsoft C# documentation, see link below.
* https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
*/

<<<<<<< Updated upstream
string answer = Console.ReadLine();

Console.WriteLine("...The end...");
Console.ReadLine(); //Stops program from exiting until we press a key

#endregion


/* Teachers corner

* Operators; +, -, /, *, %, ++, --, *=, +=, -=

* Casting
int.Parse()
Convert.ToInt32()
(int)
*/