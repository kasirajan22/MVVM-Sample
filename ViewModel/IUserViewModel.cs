using System;
using System.Collections.Generic;
using System.ComponentModel;
using MVVM_Sample.Model;

namespace MVVM_Sample.ViewModel
{
    public interface IUserViewModel
    {
        int userCount { get; }
        User user { get; set; }
        List<User> userList { get; set; }
        void SaveUser(User user);
        event PropertyChangedEventHandler PropertyChanged;
    }
}
