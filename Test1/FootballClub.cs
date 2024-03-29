public class FootballClub
{
    public string Name { get; }
    public List<Player> Players { get; } = new List<Player>();
    public List<Match> Matches { get; } = new List<Match>();
    public decimal Finances { get; private set; }
    public List<Transfer> TransferHistory { get; } = new List<Transfer>();

    public FootballClub(string name, decimal initialFinances)
    {
        Name = name;
        Finances = initialFinances;
    }

    public void AddPlayer(Player player)
    {
        Players.Add(player);
        player.TransferToClub(this, player.MarketValue);
    }

    public void ScheduleMatch(Match match)
    {
        Matches.Add(match);
    }

    public void RecordMatchResult(Match match, int goalsFor, int goalsAgainst)
    {
        match.Result = $"{goalsFor} : {goalsAgainst}";

        foreach (Player player in Players)
        {
            if (match.TeamType == "Domaća" && player.CurrentClub == this ||
                match.TeamType == "Gostujuća" && player.CurrentClub != this)
            {
                if (goalsFor > goalsAgainst)
                {
                    player.ScoreGoal();
                }
                else if (goalsFor < goalsAgainst)
                {
                    player.Assist();
                }
            }
        }

        Console.WriteLine($"Utakmica {match.Opponent} ({match.TeamType}) završila rezultatom {match.Result}.");
    }


    public void TransferPlayer(Player player, FootballClub newClub)
    {
        if (Players.Contains(player) && Finances >= player.MarketValue)
        {
            Players.Remove(player);
            newClub.AddPlayer(player);
            Finances -= player.MarketValue;
            newClub.Finances += player.MarketValue;

            TransferHistory.Add(new Transfer(this, newClub, player.MarketValue));

            Console.WriteLine($"Igrač {player.Name} uspješno prešao iz {Name} u {newClub.Name} za transfernu naknadu od {player.MarketValue:C}.");
        }
        else
        {
            Console.WriteLine($"Prijenos igrača {player.Name} nije uspio. Provjeri ima li igrač u klubu i jesu li financije dovoljne.");
        }
    }
}
