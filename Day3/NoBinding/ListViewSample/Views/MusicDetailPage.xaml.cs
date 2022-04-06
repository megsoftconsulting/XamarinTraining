using Xamarin.Forms;

namespace ListViewSample.Views
{
    public partial class MusicDetailPage : ContentPage
    {
        public MusicDetailPage(string picture, string title, string description)
        {
            InitializeComponent();

            MusicPicture.Source= picture;
            LabelTitle.Text = title;
            LabelDescription.Text = description;

        } 
    }
}
