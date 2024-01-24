using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        FootballClub myClub = new FootballClub("Moj Klub");

        Player player1 = new Player("Igrač 1", 25, "Napadač");
        Player player2 = new Player("Igrač 2", 28, "Vezni");
        myClub.AddPlayer(player1);
        myClub.AddPlayer(player2);

        Match match1 = new Match("Protivnik 1", "Domaća");
        Match match2 = new Match("Protivnik 2", "Gostujuća");
        myClub.ScheduleMatch(match1);
        myClub.ScheduleMatch(match2);

        myClub.RecordMatchResult(match1, 2, 1);
        myClub.RecordMatchResult(match2, 1, 1);

        Console.WriteLine("Izvještaj o klubu: " + myClub.Name);
        Console.WriteLine("Igrači:");
        foreach (Player player in myClub.Players)
        {
            Console.WriteLine(player.ToString());
        }

        Console.WriteLine("\nRaspored utakmica:");
        foreach (Match match in myClub.Matches)
        {
            Console.WriteLine(match.ToString());
        }

        Console.WriteLine("\nFinancije kluba: " + myClub.Finances);

        Console.ReadLine();
    }
}