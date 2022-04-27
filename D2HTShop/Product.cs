using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Product
{
    public string id { get; set; }
    public string img { get; set; }
    public string name { get; set; }
    public string price { get; set; }
    public string detail { get; set; }
    public string type { get; set; }

    public Product(string id, string img, string name, string price, string detail, string type)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.detail = detail;
        this.type = type;
    }

    public Product()
    {
    }
}