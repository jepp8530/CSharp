using System;

internal static class Program
{
    private static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1. New Game\n" +
                          "2. Load Game\n" +
                          "3. Exit Game\n");
        var choice = Console.ReadLine();
        var correctChoice = false;
        Hero newHero = null;
        while (!correctChoice)
        {
            switch (choice)
            {
                case "1":
                    newHero = CharacterCreation.CreateCharacter();
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

        Console.WriteLine("\n Your character is {0}, a {1}.", newHero.HeroName, newHero.HeroClass);

        Console.ReadLine();
    }
}

internal enum HeroClass
{
    Unknown,

    Warrior,

    Mage,

    Rogue
}

internal static class CharacterCreation
{
    public static Hero CreateCharacter()
    {
        Console.WriteLine("\n We will proceed in character creation.");
        Console.WriteLine("Please enter your character name:");

        var heroName = Console.ReadLine();

        Console.WriteLine("\nNow choose your character's class: \n" +
                          "Warrior......1\n" +
                          "Mage........2\n" +
                          "Rogue........3");

        var classChoice = Console.ReadLine();
        var correctChoice = false;
        var heroClass = HeroClass.Unknown;

        while (!correctChoice)
        {
            switch (classChoice)
            {
                case "1":
                    heroClass = HeroClass.Warrior;
                    correctChoice = true;
                    break;
                case "2":
                    heroClass = HeroClass.Mage;
                    correctChoice = true;
                    break;
                case "3":
                    heroClass = HeroClass.Rogue;
                    correctChoice = true;
                    break;
                default:
                    Console.WriteLine("Please enter a correct value.");
                    break;
            }

            if (!correctChoice)
            {
                classChoice = Console.ReadLine();
            }
        }

        return Hero.ClassSelect(heroName, heroClass);
    }
}

internal class Character
{
    private readonly int health;

    private readonly int maxHealth;

    private readonly int strength;

    private readonly int intelligence;

    private readonly int agility;

    protected Character(int health, int MaxHealth, int strength, int intelligence, int agility)
    {
        this.health = health;
        this.maxHealth = MaxHealth;
        this.strength = strength;
        this.intelligence = intelligence;
        this.agility = agility;
    }

    public int Health
    {
        get
        {
            return this.health;
        }
    }

    public int MaxHealth
    {
        get
        {
            return this.maxHealth;
        }
    }

    public int Strength
    {
        get
        {
            return this.strength;
        }
    }

    public int Intelligence
    {
        get
        {
            return this.intelligence;
        }
    }

    public int Agility
    {
        get
        {
            return this.agility;
        }
    }
}

internal sealed class Hero : Character
{
    private readonly string name;

    private readonly HeroClass @class;

    private readonly int level, experience, gold;

    public Hero(string name, HeroClass @class, int maxHealth, int strength, int intelligence, int agility)
        : base(maxHealth, maxHealth, strength, intelligence, agility)
    {
        this.name = name;
        this.@class = @class;
        this.experience = 0;
        this.gold = 0;
        this.level = 1;
    }

    public string HeroName
    {
        get
        {
            return this.name;
        }
    }

    public HeroClass HeroClass
    {
        get
        {
            return this.@class;
        }
    }

    public int Level
    {
        get
        {
            return this.level;
        }
    }

    public int Experience
    {
        get
        {
            return this.experience;
        }
    }

    public int Gold
    {
        get
        {
            return this.gold;
        }
    }

    public static Hero ClassSelect(string name, HeroClass @class)
    {
        var maxHealth = 100;
        var strength = 0; // this is not set anywhere in your original code.
        var intelligence = 10;
        var agility = 10;

        switch (@class)
        {
            case HeroClass.Warrior:
                maxHealth = maxHealth * 115 / 100;
                strength = strength * 12 / 100;
                break;
            case HeroClass.Mage:
                intelligence = intelligence * 12 / 100;
                break;
            case HeroClass.Rogue:
                agility = agility * 12 / 100;
                break;
        }

        return new Hero(name, @class, maxHealth, strength, intelligence, agility);
    }
}
