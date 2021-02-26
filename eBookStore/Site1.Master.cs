using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;


namespace eBookStore
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.Equals("admin",Session["user"]))
            {
                link1.Attributes["style"] = "visibility:visible";
                link2.Attributes["style"] = "visibility:visible";
                link3.Attributes["style"] = "visibility:visible";
            }
            else
            {
                String conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
                     + Server.MapPath("~/ebookstoredb.mdb");
                using (OleDbConnection con = new OleDbConnection(conString))
                {
                    con.Open();
                    string query = "SELECT Title FROM product";
                    LeftContent.Controls.Add(new LiteralControl("<ul>"));
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            LeftContent.Controls.Add(new LiteralControl("<li><a href='Productinfo.aspx?title=" + reader["Title"] + "'>" + reader["Title"] + "</a></li>"));
                        }
                        LeftContent.Controls.Add(new LiteralControl("</ul>"));
                    }
                }
            }
        }
        protected void HomeB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void ShopInfoB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Shopinfo.aspx");
        }
        protected void ProductInfoB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Productinfo.aspx");
        }
        protected void LogInB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void Link1Click(object sender, EventArgs e)
        {
            GridView1.Attributes["style"] = "visibility:visible";
        }
    }
}
