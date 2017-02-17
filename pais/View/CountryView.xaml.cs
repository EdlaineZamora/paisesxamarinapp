using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace pais
{
	public partial class CountryView : ContentPage
	{
		public CountryView()
		{
			InitializeComponent();
			this.BindingContext = new ViewModel.CountryViewModel();

			this.countrysList.ItemTapped += async (sender, e) =>
			{
				var country = e.Item as Model.Country;
				await App.Current.MainPage.Navigation.PushAsync(new DetailsView(country));
			};
		}
	}
}
