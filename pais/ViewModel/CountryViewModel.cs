using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using pais.API;

namespace pais.ViewModel
{
	public class CountryViewModel: INotifyPropertyChanged
	{
		public ICommand InitializeCommand { get; set; }
		private ObservableCollection<Model.Country> countrys { get; set; }
		public ObservableCollection<Model.Country> Countrys { get { return countrys;} set {
				countrys = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Countrys)));
			}
		}

		public CountryViewModel()
		{
			Countrys = new ObservableCollection<Model.Country>();
			Countrys.Add(new Model.Country { Id = 1, Name = "Brazil", Latitude = 12333, Longitude = 21333 });

			InitializeCommand = new Xamarin.Forms.Command(async () =>
			{
				var countrys2 = await API.Api.getAsync();
				Countrys = new ObservableCollection<Model.Country>(countrys2);
			});
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
