using System.Web.Mvc;

namespace MVC_Demo.Areas.Highcharts
{
    public class HighchartsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Highcharts";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Highcharts_Default",
                "Highcharts/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
