using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            if (DateTime.Now.Hour < 12)
            {
                lblStatus.Text = "Good Morning !!! Have a Nice Day";
            }
            else
            {
                lblStatus.Text = "Good AfterNoon !!! Have a Nice Day";
            }

        }

        protected void btn1_Click(object sender, EventArgs e) {
            String firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            string fullName = "Hello "+ firstName +" "+ lastName + "!!!";
            lblResult.Text = fullName;
        }
    }
}