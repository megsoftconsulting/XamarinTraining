using System;
using System.ComponentModel;

namespace MiUniversalApp
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if(value != _email)
                {
                    _email = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if(value != _password)
                {
                    _password = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
