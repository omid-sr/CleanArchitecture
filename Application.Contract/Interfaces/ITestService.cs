using Application.Contract.Models.ResponseModels;

namespace Application.Contract.Interfaces
{
    public interface ITestService
    {
        Task<List<TestResponseModel>> GetTestsAsync();
    }
}