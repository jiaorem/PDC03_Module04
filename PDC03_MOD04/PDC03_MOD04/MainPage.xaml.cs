using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_MOD04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenActivity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity1());
        }
        private async void OpenActivity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity2());
        }
        private async void OpenActivity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity3());
        }
        private async void OpenActivity04(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new activity4());
        }

        private async void OpenActivity05(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new activity5());
        }
    }
}
