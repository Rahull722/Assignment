using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace mockd
{
    public partial class Userpage : System.Web.UI.Page
    {
        Concls obj = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select * from Course_Details where Course_Name='" + TextBox1.Text + "' and Colle_Name='" + TextBox2.Text + "'";
            DataSet ds = obj.Fn_Adapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string ins = "insert into Course_Registration values(" + TextBox3.Text + ",'" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.Fn_Nonquery(ins);
            if (i == 1)
            {
                Label1.Text = "Registered";
            }
        }
    }
}