using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.OleDb;
namespace eBookStore
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginSubmitB_Click(object sender, EventArgs e)
        {
            String conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
                + Server.MapPath("~/ebookstoredb.mdb");
            using(OleDbConnection con = new OleDbConnection(conString)){
                con.Open();
                string query = "SELECT COUNT(*) FROM customer "
                    + "WHERE uname=@username AND passwd=@password";
                using(OleDbCommand cmd = new OleDbCommand(query,con)){
                    cmd.Parameters.AddWithValue("@username", UsernameTB.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTB.Text);

                    int result = (int)cmd.ExecuteScalar();

                    if (result == 1)
                    {
                        Session["user"] = UsernameTB.Text;
                        Response.Redirect("Default.aspx");
                    }
                    else {
                        ErrorMsg.Text = "Δοκιμάστε Ξανά";
                    }
                }
                con.Close();
            }
        }
        protected void ForgetPass(object sender, EventArgs e)
        {
            Panel2.Attributes["style"] = "visibility:hidden";
            Panel1.Attributes["style"] = "visibility:visible";
        }
        protected void RegistrationB_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationUser.aspx");
        }
    }
}
