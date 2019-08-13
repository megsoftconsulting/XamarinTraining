using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebViewSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public void Handle_Clicked(object sender, EventArgs e)
        {
            if(!tbxDireccion.Text.StartsWith("https://", StringComparison.CurrentCulture))
            {
                tbxDireccion.Text = "https://"+tbxDireccion.Text;
            }
            myWebBrowser.Source = tbxDireccion.Text;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
