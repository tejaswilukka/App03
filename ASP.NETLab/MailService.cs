using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ASP.NETLab
{
    public class MailService
    {
        Entity entity = new Entity();
        string[] str = new string[7];
        public string[] SignIn(int userid, string password)
        {
            entity.UserId = userid;
            entity.SignInPassword = password;
            str[0] = entity.UserId.ToString();
            str[1] = entity.SignInPassword;
            return str;
        }
        public string[] SendMail(string subject, string body)
        {
            entity.Subject = subject;
            entity.BodyText = body;
            str[2] = entity.Subject;
            str[3] = entity.BodyText;
            return str;
        }
    }
}