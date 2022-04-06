using ListViewSample.Models;
using Xamarin.Forms;

namespace ListViewSample.Views
{
    public partial class MusicsPage : ContentPage
    {
        public MusicsPage()
        {
            InitializeComponent();
        }

        private async void Item_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MusicDetailPage((MusicListView.SelectedItem as Musics).Picture, (MusicListView.SelectedItem as Musics).Name, (MusicListView.SelectedItem as Musics).Description));  
        }
    }
}
