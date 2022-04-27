using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D2HTShop
{
    public partial class product_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("index.aspx", true);
            }else
            {
                List<Product> arr = (List<Product>)Application["products"];
                foreach(Product pr in arr)
                {
                    if (pr.id == Request.QueryString["id"])
                    {
                        name.Text = pr.name;
                        price.Text = pr.price;
                        productImg.ImageUrl = pr.img;
                        btnthem.CommandArgument = pr.id;
                        details.Text = pr.detail;
                    }
                }
            }
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument.ToString();

            List<Product> arr = (List<Product>)Application["cart"];
            List<Product> arrpr = (List<Product>)Application["products"];
            if (arr.Count == 0)
            {
                arr = new List<Product>();
            }

            foreach (Product pr in arrpr)
            {
                if (pr.id == id)
                {
                    arr.Add(pr);
                    Session["quantity"] = quantity.Value;
                    break;
                }
            }
            
            Application["cart"] = arr;
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }


    }
}