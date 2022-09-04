using Domain.Interfaces;
using Domain.Models.Entities;
using Infrastructure.Persistence.Ef.Context;

namespace Infrastructure.Persistence.Ef.Repository;

public class TestRepository :GenericRepository<Test>, ITestRepository
{
    public TestRepository(ApplicationDbContext context) : base(context)
    {
    }
}