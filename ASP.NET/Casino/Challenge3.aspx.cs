using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Casino
{
    public partial class Challenge3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

            if (!this.IsPostBack)
            {
                DropDownList1.Items.Add("Red");
                DropDownList1.Items.Add("Green");
                DropDownList1.Items.Add("Yellow");

                RadioButtonList1.Items.Add("Arial");
                RadioButtonList1.Items.Add("Verdana");
                RadioButtonList1.Items.Add("Tahoma");

                Image1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {
            Panel1.BackColor = Color.FromName(DropDownList1.Text);

            greetingLabel1.Font.Name = RadioButtonList1.Text;
            if (int.Parse(sizeTextBox1.Text) > 0)
            {
                greetingLabel1.Font.Size = FontUnit.Point(int.Parse(sizeTextBox1.Text));
            }

            Image1.Visible = true;

            greetingLabel1.Text = greetingTextBox2.Text;
        }
    }
}