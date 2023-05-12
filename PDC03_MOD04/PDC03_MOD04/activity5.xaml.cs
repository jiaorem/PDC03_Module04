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
	public partial class activity5 : ContentPage
	{
		List<Contacts> contacts;
		public activity5()
		{
			InitializeComponent();

			SetupData();
			listView.ItemsSource = contacts;
		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if(listView.SelectedItem != null)
			{
				var detailPage = new DetailPage();
				detailPage.BindingContext = e.SelectedItem as Contacts;
				listView.SelectedItem = null;
				await Navigation.PushAsync(detailPage);
			}
		}
		void SetupData()
		{
			contacts = new List<Contacts>();

			contacts.Add(new Contacts
			{
				Name = "Jen Nierva",
				Age = 23,
				Occupation = "Libero",
				Country = "Philippines"
			});

            contacts.Add(new Contacts
            {
                Name = "Mina Myoui",
                Age = 24,
                Occupation = "Twicer",
                Country = "Japan"
            });

            contacts.Add(new Contacts
            {
                Name = "Chaewon Kim",
                Age = 23,
                Occupation = "Sserafimer",
                Country = "South Korea"
            });
        }
	}
}