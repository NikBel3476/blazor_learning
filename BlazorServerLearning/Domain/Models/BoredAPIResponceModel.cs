using Newtonsoft.Json;

namespace BlazorServerLearning.Domain.Models
{
	public class BoredAPIResponceModel
	{
		[JsonProperty("activity")]
		public string Activity { get; set; }
		[JsonProperty("accessibility")]
		public float Accessibility { get; set; }
		[JsonProperty("type")]
		public string Type { get; set; }
		[JsonProperty("participants")]
		public int Participants { get; set; }
		[JsonProperty("link")]
		public string Link { get; set; }

		public BoredAPIResponceModel(
			string activity = "",
			float accessibility = 0,
			string type = "",
			int participants = 0,
			string link = "")
		{
			Activity = activity;
			Accessibility = accessibility;
			Type = type;
			Participants = participants;
			Link = link;
		}
	}
}
