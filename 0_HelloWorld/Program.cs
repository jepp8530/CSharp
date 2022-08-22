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
#region 
Console.Title = "TES Hansenberg";


Console.WriteLine("Are you ready to start your adventure?");

string answer = Console.ReadLine();

bool AdventureStart = false;
if (answer == "Yes")
{
    AdventureStart = true;
}
else if (answer == "No")
{

}




if (AdventureStart == true)
{
    Console.WriteLine("Create your character.");
    Console.WriteLine("What is your name?");

    string name = "This is how to define a string variable!";

    name = Console.ReadLine();

    Console.WriteLine("Welcome " + name + ", you sound strong!");

    Console.WriteLine("Choose your race...\n-Human\n-Elf\n-Orc\n-Dwarf\n-Wolfman");

    string race = "This is how to define a string variable!";

    race = Console.ReadLine();
    Console.WriteLine("Where are you from " + race + "?");


    answer = Console.ReadLine();

    Console.WriteLine("...Your adventure begins now...");
    Console.ReadLine(); //Stops program from exiting until we press a key
}
#endregion