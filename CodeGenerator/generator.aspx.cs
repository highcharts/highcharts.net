using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;

public partial class generatoraspx : System.Web.UI.Page
{ 
    protected void Page_Load(object sender, EventArgs e)
    {       
        Clean();

        AspNetMvc framework = new AspNetMvc(Server);
        framework.GenerateCode();
    }

    private void Clean()
    {
        Directory.Delete(Server.MapPath("~/CodeGeneration/Highcharts"), true);
        Directory.CreateDirectory(Server.MapPath("~/CodeGeneration/Highcharts"));
        Directory.CreateDirectory(Server.MapPath("~/CodeGeneration/Highcharts/Enums/"));
    }
}
