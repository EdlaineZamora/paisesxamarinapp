using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pais
{
	public partial class DetailsView : ContentPage
	{
		public DetailsView(Model.Country country)
		{
			InitializeComponent();
			this.Nome.Text = country.Name;
			this.Longitude.Text = country.Longitude.ToString();
			this.Latitude.Text = country.Latitude.ToString();
		}
	}
}
