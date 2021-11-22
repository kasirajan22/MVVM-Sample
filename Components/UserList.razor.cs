using System;
using Microsoft.AspNetCore.Components;
using MVVM_Sample.ViewModel;

namespace MVVM_Sample.Components
{
    public partial class UserList
    {
        [CascadingParameter]
        IUserViewModel viewModel { get; set; }
    }
}
