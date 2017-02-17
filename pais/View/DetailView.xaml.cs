using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace pais
{
	public partial class DetailView : ContentPage
	{
		Model.Country Country;

		public DetailView(Model.Country country)
		{
			InitializeComponent();

			this.Country = country;
		}
	}
}
