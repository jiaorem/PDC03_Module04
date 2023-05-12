using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity3 : ContentPage
    {
        public activity3()
        {
            InitializeComponent();
        }

        private async void onNextPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new activity3page2());
        }

        private async void onPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}