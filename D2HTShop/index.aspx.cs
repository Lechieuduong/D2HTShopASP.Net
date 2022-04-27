using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D2HTShop
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> arr = (List<Product>)Application["products"];
            List<Product> arrFeaturedProducts = new List<Product>();
            List<Product> arrLastestProducts = new List<Product>();
            foreach(Product pr in arr)
            {
                int id = Int32.Parse(pr.id);
                if (id == 3||  id == 2 || id == 1)
                {
                    arrFeaturedProducts.Add(pr);
                }
                if (id == 4|| id == 24 || id == 13 || id == 16 || id == 7 || id == 8)
                {
                    arrLastestProducts.Add(pr);
                }
            }

            ListViewFearturedProducts.DataSource = arrFeaturedProducts;
            ListViewFearturedProducts.DataBind();

            ListViewLastestProducts.DataSource = arrLastestProducts;
            ListViewLastestProducts.DataBind();
        }
    }
}