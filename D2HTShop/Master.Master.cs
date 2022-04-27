using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D2HTShop
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> arr = (List<Product>)Application["cart"];
            TotalProduct.Text = arr.Count.ToString();

            if (Session["login"].ToString() == "1")
            {
                loregisterlogin.InnerHtml = "<a href=\"userinformation.aspx\">Your Profile</a>";
                Session["url"] = Page.Request.Url.ToString();
            }else
            {
                loregisterlogin.InnerHtml = "<a href=\"account.aspx\">Account</a> ";
            }
        }
    }
}