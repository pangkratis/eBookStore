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
    public partial class AdminProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
                + Server.MapPath("~/ebookstoredb.mdb");
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM product WHERE Category = @id";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    if (Request.QueryString["id"] != null)
                    {

                        PlaceHolder1.Controls.Add(new LiteralControl("<table><th>Όνομα</th><th>Περιγραφή</th><th>Τιμή</th>"));
                        cmd.Parameters.AddWithValue("@id", Request.QueryString["id"]);
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            PlaceHolder1.Controls.Add(new LiteralControl("<tr><td>" + reader["Title"] + "</td><td>" + reader["Description"] + "</td><td>" + reader["Price"] +
                                "</td>"));
                        }
                        PlaceHolder1.Controls.Add(new LiteralControl("</tr></br></br></table>"));
                    }
                }

                con.Close();
            }
        }
    }
}
