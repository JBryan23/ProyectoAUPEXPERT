using AUPExpert.Application.Interface.UseCases.Iterations;
using AUPExpert.Application.Interface.UseCases.Projects;
using AUPExpert.Application.Interface.UseCases.WorkFlows;
using AUPExpert.Application.Interface.UseCases.WorkFlowTasks;
using AUPExpert.Application.UseCases.Iterations;
using AUPExpert.Application.UseCases.Projects;
using AUPExpert.Application.UseCases.WorkFlows;
using AUPExpert.Application.UseCases.WorkFlowTasks;
using AUPExpert.Application.Validator;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AUPExpert.Application.UseCases
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //validaciones de fluent
            services.AddTransient<ProjectDtoValidator>();
            services.AddTransient<IterationDtoValidator>();
            services.AddTransient<WorkFlowDtoValidator>();
            services.AddTransient<WorkFlowTaskDtoValidator>();

            //agregar servicios de Automapper
            //en tiempo de ejecucion encuentra las clases que hacen mapeo de objetos Assembly.GetExecutingAssembly()
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped(typeof(IProjectApplication), typeof(ProjectApplication));
            services.AddScoped(typeof(IIterationApplication), typeof(IterationApplication));
            services.AddScoped(typeof(IWorkFlowApplication), typeof(WorkFlowApplication));
            services.AddScoped(typeof(IWorkFlowTaskApplication), typeof(WorkFlowTaskApplication));
            return services;
        }
    }
}
