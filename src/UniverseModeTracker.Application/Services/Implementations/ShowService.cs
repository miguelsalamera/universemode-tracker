using AutoMapper;
using UniverseModeTracker.Application.DTOs.Match;
using UniverseModeTracker.Application.Services.Interfaces;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;
using UniverseModeTracker.Domain.Entities;

namespace UniverseModeTracker.Application.Services.Implementations;

public class ShowService : IShowService
{
    private IShowRepository _showRepository;
    private IMapper _mapper;

    public ShowService(IShowRepository showRepository, IMapper mapper)
    {
        _showRepository = showRepository;
        _mapper = mapper;
    }

    public async Task<ShowCreateDTO> CreateShowAsync(ShowCreateDTO dto)
    {
        var show = _mapper.Map<Show>(dto);

        await _showRepository.AddAsync(show);

        return _mapper.Map<ShowCreateDTO>(show);
    }
}