using UniverseModeTracker.Application.DTOs.Superstar;

namespace UniverseModeTracker.Application.Interfaces;

public interface ISuperstarService
{
    Task<SuperstarCreateDTO> CreateSuperstarAsync(SuperstarCreateDTO createSuperstarDto);
    Task<SuperstarGetByIdDTO> GetSuperstarByIdAsync(Guid id);
    Task<IEnumerable<SuperstarGetAllDTO>> GetAllSuperstarsAsync();
    Task UpdateSuperstarAsync(Guid id, SuperstarUpdateDTO dto);
    Task DeleteSuperstarAsync(Guid id);

}