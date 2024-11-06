using MudBlazor;
using MudBlazor.Services;

namespace AUPExpert.Service.WebUI.Modules.MudBlazor
{
    internal static class MudBlazorExtension
    {
        internal static IServiceCollection AddMudBlazor(this IServiceCollection services)
        {
            services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;

                config.SnackbarConfiguration.PreventDuplicates = true;
                config.SnackbarConfiguration.NewestOnTop = true;
                config.SnackbarConfiguration.ShowCloseIcon = true;
                config.SnackbarConfiguration.VisibleStateDuration = 10000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            });

            return services;
        }
    }
}
