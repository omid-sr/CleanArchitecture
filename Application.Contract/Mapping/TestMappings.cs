using Application.Contract.Models.ResponseModels;
using AutoMapper;
using Domain.Models.Entities;

namespace Application.Contract.Mapping;

public class TestMappings : Profile
{
    public TestMappings()
    {
        CreateMap<TestResponseModel, Test>().ReverseMap();
    }
}