public class Match
{
    public string Opponent { get; }
    public string Location { get; }
    public int HomeGoals { get; private set; }
    public int AwayGoals { get; private set; }

    public Match(string opponent, string location)
    {
        Opponent = opponent;
        Location = location;
    }

    public void RecordResult(int homeGoals, int awayGoals)
    {
        HomeGoals = homeGoals;
        AwayGoals = awayGoals;
    }

    public override string ToString()
    {
        return $"{Opponent} - {Location} ({HomeGoals} : {AwayGoals})";
    }
}
