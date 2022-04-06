using Database.Models;
using Database.Views;
using Xamarin.Forms;

namespace Database
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            var items = await App.Database.GetTodoItems();
            ListTodoItems.ItemsSource = items;
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CreateTodoItemPage
            {
                BindingContext = new TodoItem()
            });
        }
        
        private async void OnListItemSelected(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) return;
            var item = e.Item as TodoItem;
            await Navigation.PushAsync(new CreateTodoItemPage()
            {
                BindingContext = item
            });
        }
    }
}