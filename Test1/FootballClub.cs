using System;
using System.Collections.Generic;

public class FootballClub
{
    public string Name { get; }
    public List<Player> Players { get; }
    public List<Match> Matches { get; }
    public decimal Finances { get; private set; }

    public FootballClub(string name)
    {
        Name = name;
        Players = new List<Player>();
        Matches = new List<Match>();
        Finances = 1000000;
    }

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

    public void ScheduleMatch(Match match)
    {
        Matches.Add(match);
    }

    public void RecordMatchResult(Match match, int homeGoals, int awayGoals)
    {
        match.RecordResult(homeGoals, awayGoals);
    }
}
