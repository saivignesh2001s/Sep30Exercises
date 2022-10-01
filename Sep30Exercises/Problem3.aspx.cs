using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace Sep30Exercises
{
    public partial class Problem3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["north"].ConnectionString);
            int i = Convert.ToInt32(TextBox2.Text);
            SqlCommand cmd = new SqlCommand($"Select * from Products where ProductID={i}",conn);
            
            conn.Open();
            SqlDataReader dr=cmd.ExecuteReader();   
            while (dr.Read())
            {
                
                TextBox1.Text = dr[1].ToString();
            }
            conn.Close();
        }
    }
}