using System.Web.Mvc;

namespace MVC_Highstock_Demo.Areas.Highstock
{
    public class HighstockAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Highstock";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Highstock_default",
                "Highstock/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
