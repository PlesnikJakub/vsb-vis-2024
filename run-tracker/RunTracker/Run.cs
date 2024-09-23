namespace RunTracker;

public abstract class Run : IRun
{
    public required string RunId { get; init; }
    public required string UserId { get; init; }
    public double Distance { get; protected set; } = 0;
    public TimeSpan Duration { get; private set; }
    public DateTime StartDate { get; private set; }

    public virtual void StartRun()
    {
        StartDate = DateTime.Now;
    }

    public virtual void EndRun()
    {
        Duration = DateTime.Now - StartDate;
    }

    public virtual string GetRunDetails()
    {
        return $"Run Id: {RunId} started at {StartDate:o}";
    }
}
    