using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp
{
    public partial class calender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack)
            {
                WelcomeLbl.Text = "Welcome";

                navLabel1.Text = Request.QueryString["q"];
                navLabel1.Text += " &" + Session["pw"];
            }
            else
            {
                WelcomeLbl.Text = "Indian Team";
            }

            
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {
            if (DropDownList1.SelectedIndex == 1)
            {
                ImagePlayer.ImageUrl = "/images/dhoni.jpg";
                playerLbl.Text = "Dhoni";
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                ImagePlayer.ImageUrl = "/images/kohli.jpg";
                playerLbl.Text = "Kohli";
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                ImagePlayer.ImageUrl = "/images/sanju.jpg";
                playerLbl.Text = "Sanju Samson";
            }
            else
            {
                ImagePlayer.AlternateText = "Not Selected";
                playerLbl.Text = "Not Selected";
            }

            
        }
    }
}