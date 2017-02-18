using System;
using System.ComponentModel;

namespace pais.Model
{
	public class Country : INotifyPropertyChanged
	{
		public Country() {}

		private int id;
		public int Id { get { return id; }
			set
			{
				id = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
			}}

		private string name;
		public string Name { get { return name; }
			set
			{
				name = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
			}}

		private double latitude;
		public double Latitude { get { return latitude; }
			set
			{
				latitude = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Latitude)));
			}}

		private double longitude;
		public double Longitude { get { return longitude; } 
			set {
				longitude = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Longitude)));
			}}

		public event PropertyChangedEventHandler PropertyChanged;
	}

}
