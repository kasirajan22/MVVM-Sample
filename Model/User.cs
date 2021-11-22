using System;
namespace MVVM_Sample.Model
{
    public class User
    {
        public User()
        {
            UserUID = Guid.NewGuid();
            IsActive = true;
        }

        public Guid UserUID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public bool IsActive { get; set; }

    }
}
