using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace D2HTShop
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["products"] = new List<Product>();
            Application["cart"] = new List<Product>();
            Application["user"] = new List<User>();

            List<User> uarr = new List<User>();
            uarr.Add(new User() { name = "duong", email = "banbetui983@gmail.com", password = "123456" });

            List<Product> arr = new List<Product>();

            //Mac
            arr.Add(new Product() {id = "1", img = "images/laptop1.jpg", name = "Macbook Pro 2022", price = "500", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1"});
            arr.Add(new Product() {id = "2", img = "images/laptop2.jpg", name = "Macbook Pro 2020", price = "450", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1" });
            arr.Add(new Product() {id = "3", img = "images/laptop3.jpg", name = "Macbook Pro 2021", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1"});

            arr.Add(new Product() {id = "4", img = "images/laptop4.png", name = "Macbook Pro 2018", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1" });
            arr.Add(new Product() {id = "5", img = "images/laptop5.png", name = "Macbook Pro 2019", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1" });
            arr.Add(new Product() {id = "6", img = "images/laptop6.png", name = "Macbook Pro 2017", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1" });

            arr.Add(new Product() { id = "7", img = "images/laptop7.png", name = "Macbook Pro 2018", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1" });
            arr.Add(new Product() { id = "8", img = "images/laptop8.png", name = "Macbook Pro 2019", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1" });
            arr.Add(new Product() { id = "9", img = "images/laptop9.png", name = "Macbook Pro 2017", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "1" });

            //Dell
            arr.Add(new Product() { id = "10", img = "images/dell1.png", name = "Dell Inspiron 15 3511 (2021)", price = "500", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });
            arr.Add(new Product() { id = "11", img = "images/dell2.png", name = "Dell Inspiron 14 (5410) 2-in-1", price = "450", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });
            arr.Add(new Product() { id = "12", img = "images/dell3.png", name = "Dell Alienware x17 R1", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });

            arr.Add(new Product() { id = "13", img = "images/dell4.png", name = "Dell Alienware x15 R1", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });
            arr.Add(new Product() { id = "14", img = "images/dell5.png", name = "Dell Latitude 9520", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });
            arr.Add(new Product() { id = "15", img = "images/dell6.png", name = "Dell Latitude 7420", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });

            arr.Add(new Product() { id = "16", img = "images/laptop7.png", name = "Dell XPS 17 (9710)", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });
            arr.Add(new Product() { id = "17", img = "images/laptop8.png", name = "Dell XPS 15 (9510)", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });
            arr.Add(new Product() { id = "18", img = "images/laptop9.png", name = "Dell Inspiron 14 (5410)", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "2" });

            //Asus
            arr.Add(new Product() { id = "19", img = "images/laptop1.jpg", name = "Asus Inspiron 15 3511 (2021)", price = "500", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });
            arr.Add(new Product() { id = "20", img = "images/laptop2.jpg", name = "Asus Inspiron 14 (5410) 2-in-1", price = "450", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });
            arr.Add(new Product() { id = "21", img = "images/laptop3.jpg", name = "Asus Alienware x17 R1", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });

            arr.Add(new Product() { id = "22", img = "images/laptop4.png", name = "Asus Alienware x15 R1", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });
            arr.Add(new Product() { id = "23", img = "images/laptop5.png", name = "Asus Latitude 9520", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });
            arr.Add(new Product() { id = "24", img = "images/laptop6.png", name = "Asus Latitude 7420", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });

            arr.Add(new Product() { id = "25", img = "images/laptop7.png", name = "Asus XPS 17 (9710)", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });
            arr.Add(new Product() { id = "26", img = "images/laptop8.png", name = "Asus XPS 15 (9510)", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });
            arr.Add(new Product() { id = "27", img = "images/laptop9.png", name = "Asus Inspiron 14 (5410)", price = "550", detail = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,", type = "3" });



            Application["products"] = arr;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}