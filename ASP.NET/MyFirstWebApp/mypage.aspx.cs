using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class mypage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {
            officeLabel.Text = officeDropdown.Text;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e) {
            if (nameTextBox.Text == " ")
            {
                nameLabel.Text = "Please Enter A valid Name";
            }
            else
            {
                string name = nameTextBox.Text;
                nameLabel.Text = name;
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        protected void empBtn_Click(object sender, EventArgs e) {

            empStatusLabel.Text = nameTextBox.Text + " " + officeDropdown.Text + " " +
                RadioButtonList1.SelectedValue ;

            foreach ( ListItem i in CheckBoxList1.Items)
            {
                if (i.Selected == true)
                {
                    empStatusLabel.Text += " " + i.Value + "<br />";
                }
            }

        }
    }
}