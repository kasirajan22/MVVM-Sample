using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MVVM_Sample.ViewModel;

namespace MVVM_Sample.Pages
{
    public partial class User : IDisposable
    {

        [Inject]
        IUserViewModel viewModel { get; set; }

        protected override async Task OnInitializedAsync()
        {
            viewModel.PropertyChanged += async (sender, e) => {
                await InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            };
            await base.OnInitializedAsync();
        }

        async void OnPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            await InvokeAsync(() =>
            {
                StateHasChanged();
            });
        }

        public void Dispose()
        {
            viewModel.PropertyChanged -= OnPropertyChangedHandler;
        }
    }
}
