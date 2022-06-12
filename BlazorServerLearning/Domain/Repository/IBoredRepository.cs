using BlazorServerLearning.Domain.Models;

namespace BlazorServerLearning.Domain.Repository
{
	public interface IBoredRepository
	{
		Task<BoredAPIResponceModel> Get();
	}
}
