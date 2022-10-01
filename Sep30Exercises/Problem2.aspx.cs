using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sep30;

namespace Sep30Exercises
{
    public partial class Problem2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customers s = new Customers();
            s.fname = TextBox2.Text;
            s.lname = TextBox3.Text;
            TextBox8.Text = Calendar1.SelectedDate.ToLongDateString();
            s.bdate = Calendar1.SelectedDate;
            s.city = TextBox5.Text;
            s.state = TextBox6.Text;
            HttpCookie k = new HttpCookie("cusdata");
            k.Expires = DateTime.Now.AddMinutes(20);
            k.Values.Add("fname", s.fname);
            k.Values.Add("lname", s.lname);
            k.Values.Add("bdate", s.bdate.ToLongDateString());
            k.Values.Add("city", s.city);
            k.Values.Add("state", s.state);
            TextBox7.Text= s.fname; 
            Response.Write(s.fname);
            Response.Cookies.Add(k);



        }
        
    }
}