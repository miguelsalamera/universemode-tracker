using AutoMapper;
using UniverseModeTracker.Domain.Entities;
using UniverseModeTracker.Application.Services.Interfaces;
using UniverseModeTracker.Application.DTOs.Superstar;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;

namespace UniverseModeTracker.Application.Services.Implementations;

public class SuperstarService : ISuperstarService
{
    private ISuperstarRepository _superstarRepository;
    private readonly IMapper _mapper;

    public SuperstarService(ISuperstarRepository superstarRepository, IMapper mapper)
    {
        _superstarRepository = superstarRepository;
        _mapper = mapper;
    }

    public async Task<SuperstarCreateDTO> CreateSuperstarAsync(SuperstarCreateDTO dto)
    {
        var superstarEntity = _mapper.Map<Superstar>(dto);

        await _superstarRepository.AddAsync(superstarEntity);

        return _mapper.Map<SuperstarCreateDTO>(superstarEntity);
    }

    public async Task<IEnumerable<SuperstarGetAllDTO>> GetAllSuperstarsAsync()
    {
        var superstarsCollection = await _superstarRepository.GetAllAsync();
        
        return _mapper.Map<IEnumerable<SuperstarGetAllDTO>>(superstarsCollection);
    }

    public async Task<SuperstarGetByIdDTO> GetSuperstarByIdAsync(Guid id)
    {
        var superstarEntity = await _superstarRepository.GetByIdAsync(id);
        
        if (superstarEntity == null)
        {
            throw new KeyNotFoundException("Superstar not found");
        }

        // Map the entity to DTO and return
        return _mapper.Map<SuperstarGetByIdDTO>(superstarEntity);
    }

    public async Task UpdateSuperstarAsync(Guid id, SuperstarUpdateDTO dto)
    {
        var superstarEntity = await _superstarRepository.GetByIdAsync(id);

        if (superstarEntity == null)
        {
            throw new KeyNotFoundException("Superstar not found");
        }

        // Map the update DTO to the existing product
        _mapper.Map(dto, superstarEntity);

        // Save changes to the repository
        await _superstarRepository.UpdateAsync(superstarEntity);
    }

    public async Task DeleteSuperstarAsync(Guid id)
    {
        var superstarEntity = await _superstarRepository.GetByIdAsync(id);

        if (superstarEntity == null)
        {
            throw new KeyNotFoundException("Superstar not found");
        }

        // Delete the product
        await _superstarRepository.DeleteAsync(id);
    }

    
}