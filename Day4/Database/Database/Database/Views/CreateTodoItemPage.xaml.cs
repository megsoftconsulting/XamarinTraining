using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Plugin.Toast;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateTodoItemPage : ContentPage
    {
        public CreateTodoItemPage()
        {
            InitializeComponent();
        }
        
        private async void OnDeleteClicked(object sender, System.EventArgs e)
        {
            var item = BindingContext as TodoItem;
            App.Database.Delete(item);
            await Navigation.PopAsync();
            CrossToastPopUp.Current.ShowToastMessage("To Do Item removed successfully");
        }
        
        private async void OnSaveClicked(object sender, System.EventArgs e)
        {
            var item = BindingContext as TodoItem;

            if (item != null && item.Id > 0)
            {
                App.Database.Update(item);
            }
            else
            {
                App.Database.Insert(item);
            }
            await Navigation.PopAsync(); 
            CrossToastPopUp.Current.ShowToastMessage("To Do Item added successfully");
        }

        private async void OnCancelClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}