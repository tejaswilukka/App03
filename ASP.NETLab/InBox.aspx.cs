using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETLab
{
    public partial class InBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cookie"];
            Label1.Text = cookie["UserId"];
            Label2.Text = cookie["Date"];
        }
    }
}