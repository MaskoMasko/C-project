public class Player
{
    public string Name { get; }
    public int Age { get; }
    public string Position { get; }

    public Player(string name, int age, string position)
    {
        Name = name;
        Age = age;
        Position = position;
    }

    public override string ToString()
    {
        return $"{Name} ({Age} godina) - {Position}";
    }
}
