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
    public partial class Productinfo : System.Web.UI.Page
    {
        String titleQuery;
        String quantityQuery;
        String priceQuery;
        protected void Page_Load(object sender, EventArgs e)
        {
            String conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
                + Server.MapPath("~/ebookstoredb.mdb");
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM product WHERE Title = @title";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    if (Request.QueryString["title"] == null)
                    {
                        cmd.Parameters.AddWithValue("@title", "Sams Teach Yourself SQL in 10 Minutes (3rd Edition)");
                    }
                    else {
                        cmd.Parameters.AddWithValue("@title", Request.QueryString["title"]);
                    }
                    
                    PlaceHolder1.Controls.Add(new LiteralControl("<form action='ShowCart.aspx'><table><th>Όνομα</th><th>Περιγραφή</th><th>Τιμή</th>"));
                    
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PlaceHolder1.Controls.Add(new LiteralControl("<tr><td>"+reader["Title"]+"</td><td>"+reader["Description"]+"</td><td>"+reader["Price"]+
                            "</td>"));
                        titleQuery = (String) reader["Title"];
                        quantityQuery = (String)TextBox1.Text;
                        priceQuery = Convert.ToString(reader["Price"]);
                    }
                    PlaceHolder1.Controls.Add(new LiteralControl("</tr></table></form>"));
                }
                
                con.Close();
            }
        }

        protected void AddCartB_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddtoCart.aspx?title="+titleQuery+"&quantity="+quantityQuery+"&price="+priceQuery);
        }

    }
}
