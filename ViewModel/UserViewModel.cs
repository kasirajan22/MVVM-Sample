using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVM_Sample.Model;

namespace MVVM_Sample.ViewModel
{
    public class UserViewModel : BaseViewModel, IUserViewModel
    {
        public int userCount
        {
            get
            {
                return userList.Count;
            }
        }
        private User tempUser = new();
        public User user
        {
            get => tempUser; set
            {
                SetValue(ref tempUser, value);                
            }
        }
        private List<User> tempUserList = new();
        public List<User> userList
        {
            get => tempUserList; set
            {
                SetValue(ref tempUserList, value);
            }
        }

        public void SaveUser(User user)
        {
            if (user.UserUID.Equals(Guid.Empty))
            {
                user.UserUID = Guid.NewGuid();
            }
            else
            {
                userList.Remove(user);
            }

            userList.Add(user);

            OnPropertyChanged(nameof(User));
        }
    }
}
