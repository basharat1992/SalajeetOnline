using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalajeetOnline
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string inputEmail = tbEmail.Text;
            string inputPassword = tbPassword.Text;
            SoDataModelDataContext dataContext = new SoDataModelDataContext();
            User user = dataContext.Users.Where(x => x.UserEmail == inputEmail && x.UserPassword == inputPassword).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show(this, "success!!");
            }
            else
            {
                MessageBox.Show(this, "email or password is not valid!!");
            }
        }
    }

    public static class MessageBox
    {
        public static void Show(this Page Page, String Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "MessageBox",
               "<script language='javascript'>alert('" + Message + "');</script>"
            );
        }
    }
}