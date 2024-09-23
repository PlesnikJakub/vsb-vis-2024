namespace RunTracker;

public class OutdoorRun : Run
{
    public string TrackType { get; init; } // Track, Trail, Road, etc => move to enum
    public IList<Position> Positions { get; private set; } = new List<Position>();

    public override void EndRun()
    {
        base.EndRun();
        Distance = CalculateDistance();
    }

    public void AddPosition(Position p)
    {
        Positions.Add(p);
    }
    public override string GetRunDetails()
    {
        var details = $"Outdoor run Id: {RunId} started at {StartDate}. \n" +
            $"Total distance: {CalculateDistance()} km \n" +
            $"Duration: {Duration.TotalSeconds} seconds \n";
        return details;
    }

    public double CalculateDistance()
    {
        var totalDistance = 0.0;
        if(Positions.Count < 2)
            return totalDistance;

        for(int i = 0; i < Positions.Count-1; i++)
        {
            totalDistance += Haversine.calculate(Positions[i].Lat, Positions[i].Lng, Positions[i+1].Lat, Positions[i+1].Lng);
        }

        return double.Round(totalDistance, 2);
    }
}
