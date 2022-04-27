using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class User
{
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }

    //public string phonenumber { get; set; }
    //public string dob { get; set; }

    public User()
    {

    }
    public User(string name, string email, string password /*, string phonenumber*//*string dob*/)
    {
        this.name = name;
        this.email = email;
        this.password = password;
        //this.phonenumber = phonenumber;
        //this.dob = dob;
    }
}