namespace TrendMusic.ECommerce.MVC.Utilities.HelperClassess
{
    public static class ActiveLinkHelper
    {
        public static string ActiveLink(IHttpContextAccessor httpContext, string AreaParam, string ControllerParam, string ActionParam)
        {
            var Area = httpContext.HttpContext.GetRouteValue("Area").ToString();
            var Controller = httpContext.HttpContext.GetRouteValue("Controller").ToString();
            var Action = httpContext.HttpContext.GetRouteValue("Action").ToString();
            return (Action.ToUpper() == AreaParam.ToUpper() && Controller.ToUpper() == ControllerParam.ToUpper() && Action.ToUpper() == ActionParam.ToUpper() ? "active" : "");

        }
    }
}
