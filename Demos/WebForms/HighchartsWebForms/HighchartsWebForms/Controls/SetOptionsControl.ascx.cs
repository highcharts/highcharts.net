using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace HighchartsWebForms.Controls
{
    public partial class SetOptionsControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var renderer = new HighchartsRenderer();

            Response.Write("<div id='aaa'></div>"+renderer.SetOptions(null, new Lang
            {
                Months = new List<string> { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" },
                ShortMonths = new List<string> { "sty", "lut", "mar", "kwi", "maj", "cze", "lip", "sie", "wrz", "paź", "lis", "gru" }
            }));
        }
    }
}