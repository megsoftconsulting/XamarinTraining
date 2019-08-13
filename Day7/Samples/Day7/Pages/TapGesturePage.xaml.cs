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
            label1.Text = $"He sido presionado {_label1Count} veces";
        }

        private void OnTappedLabel2(object sender, EventArgs e)
        {
            _label2Count++;
            label2.Text = $"He sido ejecutado {_label2Count} veces luego de 2 taps";
        }

        private void OnCommandTapped()
        {
            DisplayAlert("Tap", "Fui lanzado desde el Command del Tap Gesture Recognizer", "Ok");
        }
    }
}
