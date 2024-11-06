using AUPExpert.Service.WebUI.Services;
using AUPExpert.Service.WebUI.Services.Assistant;
using AUPExpert.Service.WebUI.Services.Iterations;
using AUPExpert.Service.WebUI.Services.Projects;
using AUPExpert.Service.WebUI.Services.WorkFlows;
using AUPExpert.Service.WebUI.Services.WorkFlowTasks;

namespace AUPExpert.Service.WebUI.Modules.Injection
{
    internal static class InjectionExtension
    {
        public static void AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<CustomDialogService>();

            services.AddScoped<ProjectService>();
            services.AddScoped<WorkFlowService>();
            services.AddScoped<WorkFlowTaskService>();
            services.AddScoped<IterationService>();

            services.AddScoped<KnowLedgeService>();
            services.AddScoped<AssistantInteractiveService>();
            services.AddScoped<InferenceIngineService>();
        }
    }
}
