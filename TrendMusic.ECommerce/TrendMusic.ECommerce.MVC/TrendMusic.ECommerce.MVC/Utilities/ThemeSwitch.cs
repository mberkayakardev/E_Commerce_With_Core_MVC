using TrendMusic.ECommerce.Managers.Abstract.Managers;

namespace TrendMusic.ECommerce.MVC.Utilities
{
    public class ThemeSwitch
    {
        private readonly ICookieService _cookieService;
        public ThemeSwitch(ICookieService cookieService)
        {
            _cookieService = cookieService;
        }

        public string GetTheme(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var result = _cookieService.GetStringCookieValueWithKey("DefaultProjectTheme");
                return result;
            }
            else
            {
                return "";
            }

        }
    }
}
