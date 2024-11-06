using AUPExpert.Service.WebUI.Components.Layout;
using FluentValidation.Results;
using Microsoft.AspNetCore.Hosting.Server;
using MudBlazor;
using MudBlazor.Extensions;

namespace AUPExpert.Service.WebUI.Services
{
    internal sealed class CustomDialogService
    {
        private readonly IDialogService _dialogService;

        public CustomDialogService(IDialogService dialogService)
        {
            _dialogService = dialogService ?? throw new ArgumentNullException(nameof(dialogService));
        }

        internal async Task ShowErrorDialogAsync(string title, string errorMessage, IEnumerable<ValidationFailure> errors)
        {
            var parameters = new DialogParameters<ErrorDialog> {
                { x => x.ErrorMessage, errorMessage },
                { x => x.Errors, errors }
            };
            await _dialogService.ShowAsync<ErrorDialog>(title, parameters);
            await Task.CompletedTask;
        }
        internal async Task<bool> ShowSimpleGenericDialogAsync(string title, string message, string buttonText, Color color)
        {
            var parameters = new DialogParameters<SimpleGenericDialog>
        {
            { x => x.ContentText, message },
            { x => x.ButtonText, buttonText},
            { x => x.Color, color }
        };

            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

            var dialog = await _dialogService.ShowAsync<SimpleGenericDialog>(title, parameters, options);
            var result = await dialog.Result;

            if (result.Canceled)
            {
                return false;
            }
            return result.Data.As<bool>();
        }
    }
}
