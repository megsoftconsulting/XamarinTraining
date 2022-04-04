using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Day7.Pages
{
    public partial class TapGesturePage : ContentPage
    {
        private int _label1Count;
        private int _label2Count;
        public ICommand Command => new Command(OnCommandTapped);
        public TapGesturePage()
        {
            InitializeComponent();
        }

        private void OnTappedLabel1(object sender, EventArgs e)
        {
            _label1Count++;
            Label1.Text = $"I have been tapped {_label1Count} times";
        }

        private void OnTappedLabel2(object sender, EventArgs e)
        {
            _label2Count++;
            Label2.Text = $"I have been executed {_label2Count} times after 2 taps";
        }

        private void OnCommandTapped()
        {
            DisplayAlert("Tap", "Executed from a command in a Tap Gesture Recognizer", "Ok");
        }
    }
}
