using Application.Contract.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Persistence.Ef.Context;
using Infrastructure.Persistence.Ef.Repository;
using Infrastructure.Persistence.Ef.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.Containers;

public static class ServiceContainer
{
    public static void RegisterServices(this IServiceCollection service, IConfiguration configuration)
    {
        AddScopedServives(service,configuration);
        AddDbContext(service, configuration);
        
        service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }

    private static void AddDbContext(IServiceCollection service, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ApplicationDbContext");
        service.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

    }

    public static void AddScopedServives(IServiceCollection service, IConfiguration configuration)
    {
        service.AddScoped<ITestService, TestService>();
        service.AddScoped<ITestRepository, TestRepository>();
        service.AddScoped<IUnitOfWork, UnitOfWork>();
        service.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
        service.AddScoped(typeof(ISpecification<>), (typeof(BaseSpecifcation<>)));
    }
}