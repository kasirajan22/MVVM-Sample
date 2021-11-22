using System;
using Microsoft.AspNetCore.Components;
using MVVM_Sample.ViewModel;

namespace MVVM_Sample.Components
{
    public partial class UserAdd
    {
        [CascadingParameter]
        IUserViewModel viewModel { get; set; }


        void SaveToDB()
        {
            viewModel.SaveUser(viewModel.user);
            viewModel.user = new();
        }
    }
}
