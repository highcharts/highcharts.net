using System.Web.Mvc;

namespace MVC_Demo.Areas.Highmaps
{
    public class HighmapsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Highmaps";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Highmaps_default",
                "Highmaps/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
