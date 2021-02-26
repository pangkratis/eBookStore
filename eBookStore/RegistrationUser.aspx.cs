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
    public partial class RegistrationUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegistrationB_Click(object sender, EventArgs e)
        {
            if (!TextBox1.Text.Equals(null) && !TextBox2.Text.Equals(null) && !TextBox3.Text.Equals(null) && !TextBox4.Text.Equals(null) && !TextBox5.Text.Equals(null) && !TextBox6.Text.Equals(null) && !TextBox7.Text.Equals(null) && !TextBox8.Text.Equals(null) && !TextBox9.Text.Equals(null) && !TextBox10.Text.Equals(null)) { 
                if( TextBox5.Text.Equals(TextBox6.Text)){
                    if( TextBox3.Text.Contains("@")){
                         Label15.Text = "Όνομα:" + TextBox1.Text;
                        Label16.Text = "Επώνυμο:" + TextBox2.Text;
                        Label17.Text = "Email:" + TextBox3.Text;
                        Label18.Text = "Διεύθυνση:" + TextBox7.Text;
                        Label19.Text = "Τηλέφωνο Επικοινωνίας:" + TextBox8.Text;
                        Label20.Text = "ΤΚ:" + TextBox9.Text;
                        Label21.Text = "Πόλη:" + TextBox10.Text;
                        Label22.Text = "Χώρα:" + DropDownList1.Text;
                        if (RadioButton1.Enabled)
                        {
                            Label23.Text = "Φύλλο:" + RadioButton1.Text;
                        }
                        else {
                            Label23.Text = "Φύλλο:" + RadioButton2.Text;
                        }

                        MultiView1.ActiveViewIndex = 1;
                    }
                }
            }
           
        }
    }
}
