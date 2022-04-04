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
                    BoxView.BackgroundColor = Color.Blue;
                    break;
                case SwipeDirection.Down:
                    BoxView.BackgroundColor = Color.Black;
                    break;
                case SwipeDirection.Left:
                    BoxView.BackgroundColor = Color.Red;
                    break;
                default:
                    BoxView.BackgroundColor = Color.Orange;
                    break;
            }
        }
    }
}
