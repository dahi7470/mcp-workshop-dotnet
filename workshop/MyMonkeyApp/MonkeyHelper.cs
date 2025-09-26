namespace MyMonkeyApp;

public static class MonkeyHelper
{
    private static readonly List<Monkey> _monkeys = new()
    {
        new Monkey
        {
            Name = "Chimpanzee",
            Description = "Highly intelligent primates known for their problem-solving abilities and complex social structures.",
            Habitat = "Tropical rainforests and woodlands of Africa",
            Diet = "Omnivorous - fruits, leaves, insects, and occasionally meat",
            Size = "120-170 cm tall, 40-70 kg",
            AsciiArt = @"
    .-''-.''-.-.''-.'''
   /               \
  |  o   o   o   o  |
   \               /
    '-..,_______,..-'
        |  ___  |
        | |   | |
        |_|___|_|"
        },
        new Monkey
        {
            Name = "Orangutan",
            Description = "Large, red-haired apes known for their intelligence and arboreal lifestyle.",
            Habitat = "Rainforests of Borneo and Sumatra",
            Diet = "Primarily frugivorous - mainly fruits, also leaves and bark",
            Size = "125-150 cm tall, 30-90 kg",
            AsciiArt = @"
      .-''''''-.
     /          \
    |  @      @  |
     \    __    /
      '.      .'
        |    |
        |____|
        |    |"
        },
        new Monkey
        {
            Name = "Baboon",
            Description = "Ground-dwelling primates with distinctive elongated snouts and powerful builds.",
            Habitat = "Savannas, grasslands, and rocky areas of Africa",
            Diet = "Omnivorous - fruits, seeds, leaves, roots, bark, stems, and occasionally meat",
            Size = "50-120 cm tall, 10-50 kg",
            AsciiArt = @"
        /\   /\
       (  . .)
        )   (
       (  v  )
      ^^  |  ^^
         /|\
        / | \
        / | \"
        },
        new Monkey
        {
            Name = "Macaque",
            Description = "Adaptable primates found in various habitats, known for their social intelligence.",
            Habitat = "Forests, mountains, and urban areas across Asia",
            Diet = "Omnivorous - fruits, seeds, leaves, bark, roots, and small animals",
            Size = "35-75 cm tall, 2-18 kg",
            AsciiArt = @"
       .-'''-.
      /       \
     |  ^   ^  |
      \   >   /
       '.___.'
         | |
         |_|
         | |"
        },
        new Monkey
        {
            Name = "Howler Monkey",
            Description = "Known for their loud calls that can be heard for miles through the forest.",
            Habitat = "Tropical rainforests of Central and South America",
            Diet = "Primarily folivorous - leaves, fruits, and flowers",
            Size = "56-92 cm tall, 4-10 kg",
            AsciiArt = @"
      .-'''''-.
     /         \
    |  O     O  |
     \    ~    /
      '.  ___.'
        |\  /|
        | \/ |
        |____|"
        },
        new Monkey
        {
            Name = "Spider Monkey",
            Description = "Agile primates with long limbs and prehensile tails, excellent at swinging through trees.",
            Habitat = "Tropical rainforests of Central and South America",
            Diet = "Primarily frugivorous - ripe fruits, also leaves and flowers",
            Size = "35-66 cm tall, 6-9 kg",
            AsciiArt = @"
        .-.   .-.
       /   \ /   \
      |  o  |  o  |
       \   / \   /
        '-'   '-'
          | |
         /| |\
        ( | | )
         \|_|/"
        }
    };

    private static readonly Random _random = new();

    public static List<Monkey> GetAllMonkeys()
    {
        return _monkeys.ToList();
    }

    public static Monkey? GetMonkeyByName(string name)
    {
        return _monkeys.FirstOrDefault(m => 
            string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    public static Monkey GetRandomMonkey()
    {
        var randomMonkey = _monkeys[_random.Next(_monkeys.Count)];
        randomMonkey.AccessCount++;
        return randomMonkey;
    }

    public static int GetTotalAccessCount()
    {
        return _monkeys.Sum(m => m.AccessCount);
    }

    public static string GetRandomAsciiArt()
    {
        string[] arts = {
            @"
    🐒 Welcome to Monkey World! 🐒
        \   ^__^
         \  (oo)\_______
            (__)\       )\/\
                ||----w |
                ||     ||",
            @"
    🐵 Monkey Business Ahead! 🐵
       .-""""""-.
      /          \
     |  @      @  |
      \    __    /
       '.      .'",
            @"
    🙈 See No Evil 🙊 Speak No Evil 🙉 Hear No Evil
           .--.    .--.    .--.
          (    )  (    )  (    )
           '--'    '--'    '--'"
        };
        
        return arts[_random.Next(arts.Length)];
    }
}