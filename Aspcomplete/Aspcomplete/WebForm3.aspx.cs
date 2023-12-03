using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Aspcomplete
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("data source = SINDHU\\ADMIN2;initial catalog=master;integrated security=true");
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd=new SqlCommand("select un,pw from signin where un=@un and pw=@pw",con);
            cmd.Parameters.AddWithValue("@un", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pw", TextBox2.Text);
            SqlDataReader i=cmd.ExecuteReader();
            if(i.Read())
            {
                Response.Redirect("WebForm1.aspx");
               
            }
            else{
                Response.Write("<script> alert('Invalid data')</script>");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string un=TextBox1.Text;
            string pw=TextBox2.Text;
            string p;
            if (un == "esakki" &pw=="123" )
            {
                SqlCommand cmd1 = new SqlCommand("select * from signin", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                p = "invalid data";
                Response.Write("p");
            }
        }
    }
}