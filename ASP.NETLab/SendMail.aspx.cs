using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETLab
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cook = new HttpCookie("cook");
            MailService service = new MailService();
            string[] str = service.SendMail(TextBox2.Text, TextBox3.Text);
            Entity entity = new Entity();

            cook["Subject"] = str[2];
            cook["Body"] = str[3];
            cook.Expires = DateTime.Now.AddDays(2);
            Response.Cookies.Add(cook);
            Response.Redirect("InBox.aspx");
        }
    }
}