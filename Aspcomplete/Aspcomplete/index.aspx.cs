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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("data source = SINDHU\\ADMIN2;initial catalog=master;integrated security=true");
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Sreg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@un", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pw", TextBox2.Text);
            cmd.Parameters.AddWithValue("@mail", TextBox3.Text);
            cmd.Parameters.AddWithValue("@age", TextBox4.Text);
            cmd.Parameters.AddWithValue("@gender", TextBox5.Text);
            cmd.Parameters.AddWithValue("@addr", TextBox6.Text);
            int i=cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("<script>alert('Registre')</script>");
            }
            else
            {
                Response.Write("<script>alert('Not Registre')</script>");
            }
            int q = int.Parse(HiddenField1.Value);
            q++;
            Label3.Text = q + "Views"+"<br>";
            HiddenField1.Value = q.ToString();
        }
    }
}