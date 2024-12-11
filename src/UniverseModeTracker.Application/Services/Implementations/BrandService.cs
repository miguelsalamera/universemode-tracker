using AutoMapper;
using UniverseModeTracker.Application.DTOs.Brand;
using UniverseModeTracker.Application.Services.Interfaces;
using UniverseModeTracker.DataAccess.Repositories.Interfaces;
using UniverseModeTracker.Domain.Entities;

namespace UniverseModeTracker.Application.Services.Implementations;

public class BrandService : IBrandService
{
    private IBrandRepository _brandRepository;
    private readonly IMapper _mapper;

    public BrandService(IBrandRepository brandRepository, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _mapper = mapper;
    }

}