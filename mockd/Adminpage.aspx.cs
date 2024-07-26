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
    public partial class Adminpage : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string view = "select * from Course_Registration";
                DataSet ds = ob.Fn_Adapter(view);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "insert into Course_Details values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = ob.Fn_Nonquery(s);
            if (i == 1)
            {
                Label1.Text = "inserted";
                string view = "select * from Course_Registration";
                DataSet ds = ob.Fn_Adapter(view);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}