using Domain.Interfaces;
using Infrastructure.Persistence.Ef.Context;

namespace Infrastructure.Persistence.Ef.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _applicationDbContext;

    public ITestRepository TestRepository { get; }

    public UnitOfWork(ApplicationDbContext applicationDbContext,
        ITestRepository testRepository)
    {
        _applicationDbContext = applicationDbContext;

        TestRepository = testRepository;
    }
    public int Complete()
    {
        return _applicationDbContext.SaveChanges();
    }
}