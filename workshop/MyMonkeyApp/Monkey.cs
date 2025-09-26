namespace MyMonkeyApp;

public class Monkey
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Habitat { get; set; } = string.Empty;
    public string Diet { get; set; } = string.Empty;
    public string Size { get; set; } = string.Empty;
    public string AsciiArt { get; set; } = string.Empty;
    public int AccessCount { get; set; } = 0;

    public override string ToString()
    {
        return $"Name: {Name}\nDescription: {Description}\nHabitat: {Habitat}\nDiet: {Diet}\nSize: {Size}";
    }
}