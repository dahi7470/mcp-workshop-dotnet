using MyMonkeyApp;

namespace MyMonkeyApp;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        Console.Clear();
        Console.WriteLine(MonkeyHelper.GetRandomAsciiArt());
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("    Welcome to the Monkey Console App!");
        Console.WriteLine("======================================");
        Console.WriteLine();

        while (running)
        {
            DisplayMenu();
            
            Console.Write("Please enter your choice (1-4): ");
            string? input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyByName();
                    break;
                case "3":
                    GetRandomMonkey();
                    break;
                case "4":
                    Console.WriteLine("\nThank you for visiting Monkey World! 🐒");
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice! Please select a number between 1 and 4.");
                    break;
            }
            
            if (running)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("┌─────────────────────────────────────┐");
        Console.WriteLine("│            MONKEY MENU              │");
        Console.WriteLine("├─────────────────────────────────────┤");
        Console.WriteLine("│ 1. List all monkeys                │");
        Console.WriteLine("│ 2. Get details for specific monkey │");
        Console.WriteLine("│ 3. Get a random monkey              │");
        Console.WriteLine("│ 4. Exit app                         │");
        Console.WriteLine("└─────────────────────────────────────┘");
        Console.WriteLine();
    }

    static void ListAllMonkeys()
    {
        Console.Clear();
        Console.WriteLine("🐵 ALL AVAILABLE MONKEYS 🐵");
        Console.WriteLine("=" + new string('=', 50));
        
        var monkeys = MonkeyHelper.GetAllMonkeys();
        
        for (int i = 0; i < monkeys.Count; i++)
        {
            Console.WriteLine($"\n{i + 1}. {monkeys[i].Name}");
            Console.WriteLine($"   Description: {monkeys[i].Description}");
            Console.WriteLine($"   Habitat: {monkeys[i].Habitat}");
            Console.WriteLine($"   Diet: {monkeys[i].Diet}");
            Console.WriteLine($"   Size: {monkeys[i].Size}");
            Console.WriteLine($"   Times selected randomly: {monkeys[i].AccessCount}");
        }
        
        Console.WriteLine($"\nTotal monkeys available: {monkeys.Count}");
        Console.WriteLine($"Total random selections: {MonkeyHelper.GetTotalAccessCount()}");
    }

    static void GetMonkeyByName()
    {
        Console.Clear();
        Console.WriteLine("🔍 FIND MONKEY BY NAME 🔍");
        Console.WriteLine("=" + new string('=', 30));
        
        var allMonkeys = MonkeyHelper.GetAllMonkeys();
        Console.WriteLine("\nAvailable monkeys:");
        foreach (var monkey in allMonkeys)
        {
            Console.WriteLine($"  - {monkey.Name}");
        }
        
        Console.Write("\nEnter monkey name: ");
        string? name = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Invalid input! Please enter a monkey name.");
            return;
        }
        
        var foundMonkey = MonkeyHelper.GetMonkeyByName(name);
        
        if (foundMonkey != null)
        {
            Console.WriteLine($"\n🐒 MONKEY FOUND! 🐒");
            Console.WriteLine("=" + new string('=', 20));
            Console.WriteLine();
            Console.WriteLine(foundMonkey.ToString());
            Console.WriteLine($"Times selected randomly: {foundMonkey.AccessCount}");
            Console.WriteLine("\nASCII Art:");
            Console.WriteLine(foundMonkey.AsciiArt);
        }
        else
        {
            Console.WriteLine($"\n❌ No monkey found with the name '{name}'.");
            Console.WriteLine("Please check the spelling and try again.");
        }
    }

    static void GetRandomMonkey()
    {
        Console.Clear();
        Console.WriteLine("🎲 RANDOM MONKEY SELECTOR 🎲");
        Console.WriteLine("=" + new string('=', 35));
        
        Console.WriteLine("\nSelecting a random monkey for you...");
        
        // Add a bit of suspense
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        
        var randomMonkey = MonkeyHelper.GetRandomMonkey();
        
        Console.WriteLine("\n");
        Console.WriteLine($"🎉 YOU GOT: {randomMonkey.Name.ToUpper()}! 🎉");
        Console.WriteLine("=" + new string('=', 30));
        Console.WriteLine();
        Console.WriteLine(randomMonkey.ToString());
        Console.WriteLine($"Times selected randomly: {randomMonkey.AccessCount}");
        Console.WriteLine("\nASCII Art:");
        Console.WriteLine(randomMonkey.AsciiArt);
        
        Console.WriteLine("\n" + MonkeyHelper.GetRandomAsciiArt());
    }
}
