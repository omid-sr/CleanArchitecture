using Application.Contract.Interfaces;
using Application.Contract.Models.ResponseModels;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services;

public class TestService : ITestService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public TestService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<List<TestResponseModel>> GetTestsAsync()
    {
        var tests = await _unitOfWork.TestRepository.GetAllAsync();
        return tests.Select(o => _mapper.Map<TestResponseModel>(o)).ToList();
    }
}