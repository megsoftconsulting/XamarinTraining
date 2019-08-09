using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiUniversalApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private LoginViewModel _loginViewModel;
        public MainPage()
        {
            InitializeComponent();
            _loginViewModel = new LoginViewModel();
            BindingContext = _loginViewModel;
        }

        public void Handle_Clicked(object sender, EventArgs args)
        {
            var validEmail = "enmanuel@torib.io";
            var validPassword = "miPassword";
            if (_loginViewModel.Email!= validEmail && _loginViewModel.Password != validPassword)
            {
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "Ok!");
            }
            else
            {
                DisplayAlert("Exito", "Tus credenciales son válidas!", "Ok!");
            }
        }
    }
}
