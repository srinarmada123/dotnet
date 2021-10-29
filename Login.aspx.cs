using System;
using System.Web.Security;
namespace project_social_media
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        EL el = new EL();
        BL bl = new BL();
        protected void cmdSignIn_Click(object sender, EventArgs e)
        {            
            el.EMAILORPHONE = txtUserName.Text;
            el.PASSWORD = txtPassWord.Text;
            int i = bl.signin(el);
            if (i > 0)
            {
                Session["un"] = el.EMAILORPHONE;
                FormsAuthentication.RedirectFromLoginPage(el.EMAILORPHONE, false);
            }
        }
    }
}