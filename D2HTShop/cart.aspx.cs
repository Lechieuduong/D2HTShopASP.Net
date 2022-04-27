using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D2HTShop
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> arr = (List<Product>)Application["cart"];
            cartList.DataSource = arr;
            cartList.DataBind();


        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument.ToString();
            List<Product> arr = (List<Product>)Application["cart"];
            foreach(Product pr in arr)
            {
                if (pr.id == id)
                {
                    arr.Remove(pr);
                    break;
                }
            }

            Application["cart"] = arr;
            cartList.DataSource = arr;
            cartList.DataBind();
            TotalProduct.Text = arr.Count.ToString();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            List<Product> arr = (List<Product>)Application["cart"];
            if (arr.Count == 0)
            {
                Response.Write("<script>confirm('Your cart dont have any product!')</script>");
            }
            else
            {
                if (Session["login"].ToString() == "1") { }
                else {
                    Response.Write("<script> var k=confirm('You have to Sign in');" +
                        "if(k==true)window.location='https://localhost:44323/account.aspx';</script>");
                }
            }
        }

        protected void btnGiamGia_Click(object sender, EventArgs e)
        {
            Session["sale"] = sale.Value;
            float totalprice = 0;
            
            int sale1 = Convert.ToInt32(Session["sale"].ToString());

            List<Product> arr = (List<Product>)Application["cart"];
            foreach (Product pr in arr)
            {
                totalprice += float.Parse(pr.price) - sale1;
            }

            TotalProduct.Text = arr.Count.ToString();
            TotalPriceProduct.Text = totalprice.ToString();
        }
    }
}