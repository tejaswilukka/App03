using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETLab
{
    public partial class ShowMailText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cook = Request.Cookies["cook"];
            Label1.Text = cook["Subject"];
            Label2.Text = cook["Body"];
        }
    }
}