using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETLab
{
    public partial class SignInPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            //if(TextBox1.Text.Length==0 || TextBox2.Text.Length==0)
            //    Response.Write("<script>alert('Please Enter a  UserId or Password')</script>");
            //if(TextBox2.Text.Length >0 && TextBox2.Text.Length<7)
            //    Response.Write("<script>alert('Password must be atleast 7 characters long')</script>");
            //if(TextBox2.Text == "<script>"
        }
    }
}