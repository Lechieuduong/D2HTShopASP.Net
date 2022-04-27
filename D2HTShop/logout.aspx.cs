using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D2HTShop
{
    public partial class logoutaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["login"] = 0;
            Session["name"] = "";
            Session["email"] = "";
            Response.Redirect("account.aspx");
        }
    }
}