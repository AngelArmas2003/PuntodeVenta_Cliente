using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkAutoHome.Pages
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["IdUsuario"] = null;
            Session["Nombre"] = null;
            Response.Redirect("~/Pages/Login");//move to the next link i.e default.aspx
        }
    }
}