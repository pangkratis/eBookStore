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

namespace eBookStore
{
    public partial class ShowCart : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
            /*if( Request.QueryString["quantity"]!= null && Request.QueryString["price"] != null && Request.QueryString["title"] != null){
                int finalprice=0;
                finalprice = Int32.Parse(Request.QueryString["quantity"]) * Int32.Parse(Request.QueryString["price"]);
                cell.InnerText = Request.QueryString["title"];
                row.Cells.Add(cell);
                cell = new HtmlTableCell();
                cell.InnerText = Request.QueryString["quantity"];
                row.Cells.Add(cell);
                cell = new HtmlTableCell();
                cell.InnerText = Convert.ToString(finalprice);
                row.Cells.Add(cell);
                CartTable.Rows.Add(row);
                //PlaceHolder1.Controls.Add(new LiteralControl("<tr><td>"+Request.QueryString["title"]+"</td><td>"+Request.QueryString["quantity"]+"</td><td>"+finalprice+"</td></tr>"));
            

            }*/

           if (Session["Cart"] != null)
        {
            Literal1.Text = "<table><tr><td>Τίτλος</td><td>Ποσότητα</td><td>τιμή</td></tr>";
            Cart myCart = new Cart(); 
            CartItem tempItem;
            myCart = (Cart) Session["Cart"];
            for (int i=0; i<myCart.getItems().Count;i++){
                tempItem = (CartItem) myCart.getItems()[i];
                Literal1.Text += "<tr><td>" + tempItem.ProdTitle+"</td>";
                Literal1.Text += "<td>" + tempItem.ProdQuantity + "</td>";
                double finalprice = Convert.ToDouble(tempItem.ProdQuantity) * tempItem.Price;
                Literal1.Text += "<td>" + finalprice + "</td></tr>";
            }

            Literal1.Text += "</table>";



        }
        }
    }
}
