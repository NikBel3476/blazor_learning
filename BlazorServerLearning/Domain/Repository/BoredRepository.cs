using BlazorServerLearning.Domain.Models;
using BlazorServerLearning.Network;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlazorServerLearning.Domain.Repository
{
	public class BoredRepository : IBoredRepository
	{
		public async Task<BoredAPIResponceModel> Get()
		{
			var request = new FetchBoredAPIData("http://www.boredapi.com/api/activity/");
			var response = await request.Run();
			if(response != null)
			{
				BoredAPIResponceModel? boredDeals = JsonConvert.DeserializeObject<BoredAPIResponceModel>(response);
				return boredDeals;
			}
				return new BoredAPIResponceModel();
			 
		}
	}
}
