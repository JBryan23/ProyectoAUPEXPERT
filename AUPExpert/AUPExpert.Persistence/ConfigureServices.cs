using AUPExpert.Application.Interface.Persistence;
using AUPExpert.Persistence.Contexts;
using AUPExpert.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AUPExpert.Persistence
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration) 
        {
            string connectionString = configuration.GetConnectionString("AUPExpertConnection")!;
            //servicio de base de datos
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IProjectRepository), typeof(ProjectRepository));
            services.AddScoped(typeof(IIterationRepository), typeof(IterationRepository));
            services.AddScoped(typeof(IWorkFlowRespository), typeof(WorkFlowRepository));
            services.AddScoped(typeof(IWorkFlowTaskRepository), typeof(WorkFlowTaskRepository));

            return services;
        }
    }
}
