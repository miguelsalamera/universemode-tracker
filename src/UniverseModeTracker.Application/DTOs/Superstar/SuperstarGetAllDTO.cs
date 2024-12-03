namespace UniverseModeTracker.Application.DTOs.Superstar;

public class SuperstarGetAllDTO
{
    public Guid Id { get; set; }
    public string RingName { get; set; }
    public int WinCount { get; set; }
    public int LossCount { get; set; }
    public int NoContestCount { get; set; }
}