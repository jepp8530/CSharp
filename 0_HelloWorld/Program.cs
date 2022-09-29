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

void Story(string text, int time = 25)
{
    Console.ForegroundColor = ConsoleColor.White;
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(time);
    }
    Console.ForegroundColor = ConsoleColor.Red;
}

Console.WriteLine("The Elder Scrolls: Hansenberg");
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
Console.WriteLine("Choose your race...");

string[] ethnicity = { "1. Human", "2. Elf", "3. Orc", "4. Dwarf", "5. Wolfman"};

Console.WriteLine(ethnicity[0]);
Console.WriteLine(ethnicity[1]);
Console.WriteLine(ethnicity[2]);
Console.WriteLine(ethnicity[3]);
Console.WriteLine(ethnicity[4]);

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

for (int i = 0; i < inputStrings.Count; i++)
{
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
    Console.WriteLine("You chose class number " + setup);
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

Console.WriteLine("Are you ready to start your adventure, " + name + "?");
string begin = Console.ReadLine();
var began = false;
while (!began)
{
    switch (begin)
    {
        case "Yes":
            began = true;
            break;
        case "No":
            Console.WriteLine("Well then. Just say when you are ready...");
            break;
        case "yes":
            began = true;
            break;
        case "no":
            Console.WriteLine("Well then. Just say when you are ready...");
            break;
        default:
            Console.WriteLine("I asked, are you ready to start your adventure, " + name + "?.");
            break;
    }
    if (!began)
    {
        begin = Console.ReadLine();
    }
}
Console.WriteLine("...Your adventure begins now..." + "\nPress any key to continue");
Console.ReadLine();
string myText = "You awaken in a foreign room with no recolection of arriving. You see that you are on a bed in some kind of bedroom. What will you do?...";
for (int i = 0; i < myText.Length; i++)
{
    Console.Write(myText[i]);
    System.Threading.
    Thread.Sleep(25);
}


Console.WriteLine("\n1. Look for a way out." +
"\n2. Take a nap.");
{
    System.Threading.
    Thread.Sleep(25);
    var wokeup = Console.ReadLine();
    var awaken = false;
    while (!awaken)
    {
        switch (wokeup)
        {
            case "1":
                awaken = true;
                break;
            case "2":
                {
                    Console.WriteLine("You take a nap." +
                    "\nWhat will you do now?..." +
                    "\n1. Look for a way out." +
                    "\n2. Take a nap.");
                }
                break;
            default:
                Console.WriteLine("Please pick a choice.");
                break;
        }
        if (!awaken)
        {
            wokeup = Console.ReadLine();
        }

    }
}    


string myText1 = "You see a wooden door at the end of the room and you try to open it. It opens with a loud creak. The room on the other side is very bright and your eyes take a little while to adjust to the new lighting. Once they're adjusted, you see a man standing with his back to you. You walk over to him and tap him on the shoulder. He jumps a little and turns around. His face is old and grimy. His mouth opens and he says\n";
for (int i = 0; i < myText1.Length; i++)
{
    Console.Write(myText1[i]);
    System.Threading.
    Thread.Sleep(25);
}

Story("Hey, you. You're finally awake. You were caught trying to cross the border, right? Walked right into that Imperial ambush.");

Console.ReadLine();//Stops program from exiting until we press a key
#endregion