using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MvcHighstock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Clean();

        HighstockAspNetMvc framework = new HighstockAspNetMvc(Server);
        framework.GenerateCode();
    }

    private void Clean()
    {
        //Directory.Delete(Server.MapPath("~/CodeGeneration/Highstock"), true);
        Directory.CreateDirectory(Server.MapPath("~/CodeGeneration/Highstock"));
        Directory.CreateDirectory(Server.MapPath("~/CodeGeneration/Highstock/Enums/"));
    }
}