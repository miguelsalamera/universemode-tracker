using AutoMapper;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.Application.Services.Interfaces;
using UniverseModeTracker.Application.DTOs.Match;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.Application.Services.Implementations;

public class MatchService : IMatchService
{
    private IMatchRepository _matchRepository;
    private readonly IMapper _mapper;

    public MatchService(IMatchRepository matchRepository, IMapper mapper)
    {
        _matchRepository = matchRepository;
        _mapper = mapper;
    }

    public async Task<MatchCreateDTO> CreateMatchAsync(MatchCreateDTO dto)
    {
        var match = _mapper.Map<Match>(dto);

        await _matchRepository.AddAsync(match);

        return _mapper.Map<MatchCreateDTO>(match);
    }
}