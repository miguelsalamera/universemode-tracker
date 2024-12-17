using UniverseModeTracker.Application.DTOs.Corner;

namespace UniverseModeTracker.Application.DTOs.Match;

public class MatchCreateDTO
{
    public Guid ShowId { get; set; }
    public int Order { get; set; }
    public List<CornerCreateDTO> Corners { get; set; }
}
