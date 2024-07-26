using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mockd
{
    public partial class Login : System.Web.UI.Page
    {
        Concls obj = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(Login_Id) from Login where Username='" + TextBox1.Text + "' and Username='" + TextBox2.Text + "'";
            string s = obj.Fn_Scalar(sel);
            if (s == "1")
            {
                string l = "select Log_Type from Login where Username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string lg = obj.Fn_Scalar(l);
                if (lg == "User")
                {
                    string lt = "select Reg_Id from Login where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                    string t = obj.Fn_Scalar(lt);
                    Session["uid"] = t;
                    Response.Redirect("Userpage.aspx");
                }
                else if (lg == "Admin")
                {
                    Response.Redirect("Adminpage.aspx");
                }
            }
        }
    }
}