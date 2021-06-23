using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBaseApp
{
    public partial class crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            TextBox1.Text = "";
            TextBox2.Text = "";

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e) {
            if (TextBox1.Text == "")
            {
                TextBox1.Text = Calendar1.SelectedDate.ToString();
            }
            else
            {
                TextBox2.Text = Calendar1.SelectedDate.ToString();
            }
        }
    }
}