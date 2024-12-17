using AutoMapper;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.Application.Services.Interfaces;
using UniverseModeTracker.Application.DTOs.Match;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;
using UniverseModeTracker.Application.DTOs.Corner;

namespace UniverseModeTracker.Application.Services.Implementations;

public class MatchService : IMatchService
{
    private IMatchRepository _matchRepository;
    private ICornerRepository _cornerRepository { get; set; }
    private ICompetitorRepository _competitorRepository { get; set; }
    private readonly IMapper _mapper;

    public MatchService(IMatchRepository matchRepository, ICornerRepository cornerRepository, ICompetitorRepository competitorRepository, IMapper mapper)
    {
        _matchRepository = matchRepository;
        _cornerRepository = cornerRepository;
        _competitorRepository = competitorRepository;
        _mapper = mapper;
    }

    public async Task<bool> CreateMatchAsync(MatchCreateDTO dto)
    {
        Guid matchId = Guid.NewGuid();

        var matchEntity = new Match()
        {
            Id = matchId,
            ShowId = dto.ShowId,
            Order = dto.Order
        };

        await _matchRepository.AddAsync(matchEntity);

        foreach(var corner in dto.Corners)
        {
            Guid cornerId = Guid.NewGuid();

            var cornerEntity = new Corner()
            {
                Id = cornerId,
                MatchId = matchId
            };
            
            await _cornerRepository.AddAsync(cornerEntity);

            foreach(var competitor in corner.Competitors)
            {
                var competitorEntity = new Competitor
                {
                    SuperstarId = competitor.SuperstarId,
                    IsManager = competitor.IsManager,
                    CornerId = cornerId 
                };

                await _competitorRepository.AddAsync(competitorEntity);
            }
        }

        
        await _matchRepository.SaveAsync();
        
        await _cornerRepository.SaveAsync();
            
        await _competitorRepository.SaveAsync();

        return true;
    }
}