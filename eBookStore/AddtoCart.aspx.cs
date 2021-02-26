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
    public partial class AddtoCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Request.QueryString["quantity"] != null) && (Request.QueryString["title"] != null) && (Request.QueryString["price"] != null))
            {
                if (Session["cart"] == null)
                    Session.Add("cart", new Cart());
                ((Cart)Session["cart"]).addItem(Request.QueryString["title"], Request.QueryString["quantity"], double.Parse(Request.QueryString["price"]));
            }
            Response.Redirect("ShowCart.aspx");
        }
    }
}
