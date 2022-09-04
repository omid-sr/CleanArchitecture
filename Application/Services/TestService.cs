using Application.Contract.Interfaces;
using Domain.Interfaces;

namespace Application.Services;

public class TestService:ITestService
{
    private readonly IUnitOfWork _unitOfWork;

    public TestService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

}