using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep30Exercises
{
    public partial class Problem1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            
                if (namebox.Text == "abc" && password.Text == "abc@1234")
                {
                TextBox2.Text = "Entered successfully";
                }
                else
                {
                TextBox2.Text = "Try again..";
                }
            
        }
    }
}