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
        HttpCookie cookie = new HttpCookie("cookie");
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            MailService service = new MailService();
            string[] str=service.SignIn(Convert.ToInt32(TextBox1.Text), TextBox2.Text);
            Entity entity = new Entity();
           
            cookie["UserId"] = str[0];
            cookie["SignInPassword"] = str[1];
            cookie["Date"] = Convert.ToString(DateTime.Now);
           
            cookie.Expires = DateTime.Now.AddDays(2);
            Response.Cookies.Add(cookie);
            Response.Redirect("SendMail.aspx");
        }
    }
}