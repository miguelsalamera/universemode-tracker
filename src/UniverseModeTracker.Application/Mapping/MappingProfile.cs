using UniverseModeTracker.Application.DTOs.Superstar;
using UniverseModeTracker.Domain.Entities;
using AutoMapper;
using UniverseModeTracker.Application.DTOs.Brand;
using UniverseModeTracker.Application.DTOs.Match;


namespace UniverseModeTracker.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Superstar, SuperstarCreateDTO>().ReverseMap();
        CreateMap<Superstar, SuperstarDeleteDTO>().ReverseMap();
        CreateMap<Superstar, SuperstarGetAllDTO>().ReverseMap();
        CreateMap<Superstar, SuperstarGetByIdDTO>().ReverseMap();
        CreateMap<Superstar, SuperstarUpdateDTO>().ReverseMap();

        CreateMap<Brand, BrandCreateDTO>().ReverseMap();
        CreateMap<Brand, BrandGetAllDTO>().ReverseMap();

        CreateMap<Show, ShowCreateDTO>().ReverseMap();
    }
}