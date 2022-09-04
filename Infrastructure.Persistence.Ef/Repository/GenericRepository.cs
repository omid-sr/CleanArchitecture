using Domain.Interfaces;
using Infrastructure.Persistence.Ef.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Ef.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;
    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }
    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync();
    }

    public IEnumerable<T> FindWithSpecificationPattern(ISpecification<T> specification = null)
    {
        return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), specification);
    }
}