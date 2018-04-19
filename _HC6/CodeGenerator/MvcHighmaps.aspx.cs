using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class MvcHighmaps : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Clean();

        HighmapsAspNetMvc framework = new HighmapsAspNetMvc(Server);
        framework.GenerateCode();
    }

    private void Clean()
    {
        if(Directory.Exists(Server.MapPath("~/CodeGeneration/Highmaps")))
            Directory.Delete(Server.MapPath("~/CodeGeneration/Highmaps"), true);

        
        Directory.CreateDirectory(Server.MapPath("~/CodeGeneration/Highmaps"));
        Directory.CreateDirectory(Server.MapPath("~/CodeGeneration/Highmaps/Enums/"));
    }
}