namespace BlazorServerLearning.Network
{
	public class FetchBoredAPIData
	{
		string addressUrl;

		public string? responseData { get; set; }

		public FetchBoredAPIData(string addressUrl)
		{
			this.addressUrl = addressUrl;
		}

		public async Task<string> Run()
		{
			var client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });

			try
			{
				var response = await client.GetAsync(addressUrl);
				if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
					return null;

				var responseData = await response.Content.ReadAsStringAsync();
				return responseData;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
