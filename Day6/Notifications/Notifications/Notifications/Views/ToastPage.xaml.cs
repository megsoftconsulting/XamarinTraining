using System;
using Plugin.Toast;
using Xamarin.Forms.Xaml;

namespace Notifications.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToastPage
    {
        public ToastPage()
        {
            InitializeComponent();
        }

        private void Toast_Clicked(object sender, EventArgs e)
        {
            CrossToastPopUp.Current.ShowToastMessage("What a great Toast!");
        }
    }
}