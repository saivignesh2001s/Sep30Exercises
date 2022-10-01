using Sep30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep30Exercises
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            HttpCookie t;
            t = Request.Cookies.Get("cusdata");
            Customers customers = new Customers();
            customers.fname = t["fname"];
            customers.lname = t["lname"];
            customers.bdate = Convert.ToDateTime(t["bdate"]);
            customers.state = t["state"];
            customers.city = t["city"];
            Response.Write($"Welcome {customers.fname}");
            ListBox1.Items.Add(customers.fname+" "+customers.lname+" "+customers.bdate+" "+customers.state+" "+customers.city);

        }
    }
}