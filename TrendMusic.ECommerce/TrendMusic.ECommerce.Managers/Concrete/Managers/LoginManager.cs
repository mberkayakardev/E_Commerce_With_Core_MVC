using TrendMusic.ECommerce.Core.Utilities.Results.BaseResult;
using TrendMusic.ECommerce.Managers.Abstract;

namespace TrendMusic.ECommerce.Managers.Concrete.Managers
{
	public class LoginManager : ILoginService
	{
		public Task<IResult> LoginUsernameOrMailWithPassword(string Username, string Password)
		{
			throw new NotImplementedException();
		}
	}
}
