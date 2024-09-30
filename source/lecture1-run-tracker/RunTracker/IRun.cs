namespace RunTracker;

public interface IRun
{
    public string RunId { get; }
    public string UserId { get; }

    public void EndRun();
    public void StartRun();
    public string GetRunDetails();
}