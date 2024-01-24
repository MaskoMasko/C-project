public class Transfer
{
    public FootballClub? FromClub { get; }
    public FootballClub? ToClub { get; }
    public decimal TransferFee { get; }

    public Transfer(FootballClub? fromClub, FootballClub? toClub, decimal transferFee)
    {
        FromClub = fromClub;
        ToClub = toClub;
        TransferFee = transferFee;
    }

    public override string ToString()
    {
        if (FromClub == null)
        {
            return $"{ToClub?.Name} ({TransferFee:C})";
        }
        else if (ToClub == null)
        {
            return $"{FromClub.Name} ({TransferFee:C})";
        }
        else if (FromClub == null && ToClub == null)
        {
            return "N/A";
        }
        else if (FromClub == ToClub)
        {
            return $"{FromClub.Name} ({TransferFee:C})";
        }
        else if (FromClub != ToClub)
        {
            return $"{FromClub?.Name} -> {ToClub.Name} ({TransferFee:C})";
        }
        else
        {
            return "N/A";
        }
    }
}
