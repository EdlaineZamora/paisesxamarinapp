using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace pais.API
{
	public static class Api
	{
		public static async Task<List<Model.Country>> getAsync()
		{
			using (var client = new HttpClient())
			{
				var json = await client.GetStringAsync("https://stormy-bayou-15090.herokuapp.com/country");
				var countrys = JsonConvert.DeserializeObject<List<Model.Country>>(json);
				return countrys;
			}
		}
	}
}
