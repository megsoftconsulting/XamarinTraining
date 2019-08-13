using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Day7.Pages
{
    public partial class SwipeGesturePage : ContentPage
    {
        public SwipeGesturePage()
        {
            InitializeComponent();
        }

        private void OnSwipped(object sender, SwipedEventArgs e)
        {
            switch(e.Direction)
            {
                case SwipeDirection.Up:
                    boxView.BackgroundColor = Color.Blue;
                    break;
                case SwipeDirection.Down:
                    boxView.BackgroundColor = Color.Black;
                    break;
                case SwipeDirection.Left:
                    boxView.BackgroundColor = Color.Red;
                    break;
                default:
                    boxView.BackgroundColor = Color.Orange;
                    break;
            }
        }
    }
}
