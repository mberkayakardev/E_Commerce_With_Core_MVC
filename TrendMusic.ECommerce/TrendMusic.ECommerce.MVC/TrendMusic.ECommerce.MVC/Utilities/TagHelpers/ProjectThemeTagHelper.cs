using Microsoft.AspNetCore.Razor.TagHelpers;
using TrendMusic.ECommerce.Managers.Abstract.Managers;

namespace TrendMusic.ECommerce.MVC.Utilities.TagHelpers
{
    [HtmlTargetElement("project-theme")]
    public class ProjectThemeTagHelper : TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICookieService cookieService;
        public ProjectThemeTagHelper(IHttpContextAccessor httpContextAccessor, ICookieService cookieService)
        {
            _httpContextAccessor = httpContextAccessor;
            this.cookieService = cookieService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }

    }
}
