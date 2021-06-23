using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Casino
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e) {
            Response.Redirect("Challenge1.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e) {
            Response.Redirect("Challenge2.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e) {
            Response.Redirect("Challenge3.aspx");
        }
    }
}