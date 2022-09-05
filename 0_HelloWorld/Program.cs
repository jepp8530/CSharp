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
Console.ForegroundColor = ConsoleColor.Blue;
Console.Title = "TES Hansenberg";

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("1. New Game\n" +
                  "2. Load Game\n" +
                  "3. Exit Game\n");
var choice = Console.ReadLine();
var correctChoice = false;
while (!correctChoice)
{
    switch (choice)
    {
        case "1":
            correctChoice = true;
            break;
        case "2":
            Console.WriteLine("This feature is not yet implemented.");
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Please enter a correct value.");
            break;
    }

    if (!correctChoice)
    {
        choice = Console.ReadLine();
    }
}

Console.WriteLine("Create your character:");
Thread.Sleep(500);
Console.WriteLine("Choose your race..." +
"\n1. Human" +
"\n2. Elf" +
"\n3. Orc" +
"\n4. Dwarf" +
"\n5. Wolfman");
var race = Console.ReadLine();
var choserace = false;
while (!choserace)
{
    switch (race)
    {
        case "1":
            choserace = true;
            break;
        case "2":
            choserace = true;
            break;
        case "3":
            choserace = true;
            break;
        case "4":
            choserace = true;
            break;
        case "5":
            choserace = true;
            break;
        default:
            Console.WriteLine("Please enter a correct value.");
            break;
    }

    if (!choserace)
    {
        race = Console.ReadLine();
    }
}
Thread.Sleep(200);

Console.WriteLine("Choose your Gender..." +
"\n1. Male" +
"\n2. Female");
var gender = Console.ReadLine();
var chosegender = false;
while (!chosegender)
{
    switch (gender)
    {
        case "1":
            chosegender = true;
            break;
        case "2":
            chosegender = true;
            break;
        default:
            Console.WriteLine("Please enter a correct value.");
            break;
    }

    if (!chosegender)
    {
        gender = Console.ReadLine();
    }
}
Thread.Sleep(200);

Console.WriteLine("Choose your class...");
List<string> inputStrings = new List<string>();
inputStrings.Add("1. Warrior");
inputStrings.Add("2. Thief");
inputStrings.Add("3. Monk");
inputStrings.Add("4. Mage");
inputStrings.Add("5. Assassin");

for(int i = 0; i < inputStrings.Count; i++){
    Console.WriteLine(inputStrings[i]);
}

string setup = Console.ReadLine();
var chosesetup = false;
while (!chosesetup)
{
    switch (setup)
    {
        case "1":
            chosesetup = true;
            break;
        case "2":
            chosesetup = true;
            break;
        case "3":
            chosesetup = true;
            break;
        case "4":
            chosesetup = true;
            break;
        case "5":
            chosesetup = true;
            break;
        default:
            Console.WriteLine("Please enter a correct value.");
            break;
    }
    Console.WriteLine("You chose " + setup);
            if (!chosesetup)
    {
        setup = Console.ReadLine();
    }
}

Thread.Sleep(200);

Console.WriteLine("What is your name?");
Thread.Sleep(500);
string name = "This is how to define a string variable!";

name = Console.ReadLine();

Console.WriteLine("Are you ready to start your adventure, " + name);

Console.WriteLine("...Your adventure begins now...");
Console.ReadLine();
Console.WriteLine("You awaken in a foreign place with no recolection of arriving. You see that you are on a bed in some kind of bedroom. What will you do?..." +
"\nLook for a way out." +
"\nTake a nap."
);

Console.ReadLine(); //Stops program from exiting until we press a key

#endregion