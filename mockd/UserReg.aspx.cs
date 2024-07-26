using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mockd
{
    public partial class UserReg : System.Web.UI.Page
    {
        Concls obj = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(User_Id) from User_Registration";
            string s = obj.Fn_Scalar(sel);
            int reg_id = 0;
            if (s == "")
            {
                reg_id = 1;
            }
            else
            {
                int new_id = Convert.ToInt32(s);
                reg_id = new_id + 1;
            }
            string ins = "insert into User_Registration values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj.Fn_Nonquery(ins);
            if (i == 1)
            {
                string inslog = "insert into Login values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','User')";
                int j = obj.Fn_Nonquery(inslog);
                if (j == 1)
                {
                    Label1.Text = "inserted";
                }
            }
        }
    }
}