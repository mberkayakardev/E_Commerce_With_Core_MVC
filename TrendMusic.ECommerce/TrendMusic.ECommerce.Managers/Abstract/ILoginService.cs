using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;

namespace TrendMusic.ECommerce.Managers.Abstract
{
	public interface ILoginService
	{
		Task<IResult> LoginUsernameOrMailWithPassword(string Username, string Password);
	}
}
