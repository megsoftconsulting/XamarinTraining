using System;
using System.Collections;
using System.Collections.Generic;
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

        async void Item_Clicked(object sender, System.EventArgs e)
        {
            var musicDetailPage = new MusicDetailPage();
            musicDetailPage.BindingContext = MusicLitsView.SelectedItem as Musics;
            await Navigation.PushAsync(musicDetailPage);  
        }
    }
}
