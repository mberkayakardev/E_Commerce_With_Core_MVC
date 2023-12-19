using Microsoft.AspNetCore.Http;

namespace TrendMusic.ECommerce.Managers.Abstract.Managers
{
    public class CookieManager : ICookieService
    {
        private readonly IHttpContextAccessor _HttpContext;
        public CookieManager(IHttpContextAccessor HttpContext)
        {
            _HttpContext = HttpContext;
        }

        public string GetStringCookieValueWithKey(string Key)
        {
            return "";
        }
    }
}
