using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D2HTShop
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["type"] != null)
            {
                string type = Request.QueryString["type"];
                if (type == "1") {
                    titleproducts.Text = "Apple";
                }else if (type == "2")
                {
                    titleproducts.Text = "Dell";
                }
                else if (type == "3")
                {
                    titleproducts.Text = "Asus";
                }
                List<Product> arr = (List<Product>)Application["products"];
                List<Product> arrAllProducts = new List<Product>();

                foreach (Product sp in arr)
                {
                    if (sp.type == type) { arrAllProducts.Add(sp); }
                }
                ListViewAllProducts.DataSource = arrAllProducts;
                ListViewAllProducts.DataBind();
            }else
            {
                if (Request.QueryString["search"] == null)
                {
                    titleproducts.Text = "All Products";
                    List<Product> arr = (List<Product>)Application["products"];
                    ListViewAllProducts.DataSource = arr;
                    ListViewAllProducts.DataBind();
                }else
                {
                    Product sp1 = new Product();
                    string search = Request.QueryString["search"];
                    string typesearch = " ";
                    if (search == "Apple")
                    {
                        typesearch = "1";
                    }else if (search == "Dell" /*|| search == "dell"*/)
                    {
                        typesearch = "2";
                    }else if (search == "Asus")
                    {
                        typesearch = "3";
                    }
                    else
                    {
                        List<Product> arr = (List<Product>)Application["products"];
                        List<Product> arr1 = new List<Product>();
                        foreach (Product pr in arr)
                        {
                            string s = pr.name.IndexOf(search).ToString();
                            if (s != "-1") { arr1.Add(pr);}
                        }
                        titleproducts.Text = "Search result ";
                        ListViewAllProducts.DataSource = arr1;
                        ListViewAllProducts.DataBind();
                        return;
                    }
                    titleproducts.Text = "Search result";
                    List<Product> arr2 = (List<Product>)Application["products"];
                    List<Product> arr3 = new List<Product>();
                    foreach (Product sp in arr2) { if (sp.type == typesearch) { arr3.Add(sp); }}
                    ListViewAllProducts.DataSource = arr3;
                    ListViewAllProducts.DataBind();
                    return;
                }
            }
        }
    }
}