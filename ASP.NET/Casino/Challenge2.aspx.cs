using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Casino
{
    public partial class Challenge2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add(new ListItem("US Dollar","74"));
                DropDownList1.Items.Add(new ListItem("Euro", "88"));
                DropDownList1.Items.Add(new ListItem("Kuwait Dinar", "246"));
                DropDownList1.Items.Add(new ListItem("Soudi Riyal", "20"));

                ImageGraph.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {

            decimal currency = 0;

            if (!Decimal.TryParse(TextBox1.Text, out currency) || currency <= 0)
            {
                resultLabel.Style["color"] = "Red";
                resultLabel.Text = "Only Positive Numbers are allowed";
                return;
            }

            resultLabel.Text = "";

            ConvertCurrencyTo(currency);
        }

        public void ConvertCurrencyTo(decimal c) {
            int index = DropDownList1.SelectedIndex;
            decimal converted = 0;

            /*
            switch (index)
            {
                case 0:
                    converted = c * 74;
                    break;
                case 1:
                    converted = c * 88;
                    break;
                case 2:
                    converted = c * 246;
                    break;
                case 3:
                    converted = c * 20;
                    break;
                default:
                    break;
            }
            */

            ListItem item = DropDownList1.Items[DropDownList1.SelectedIndex];

            converted = c * Decimal.Parse(item.Value);

            resultLabel.Text = c.ToString() + " Indian Rupees equals " + converted.ToString() + " " + DropDownList1.SelectedItem; ;
        }

        protected void Button2_Click(object sender, EventArgs e) {
            ImageGraph.ImageUrl = "/images/"+ "chart"+ DropDownList1.SelectedIndex.ToString()+".png";
            ImageGraph.Visible = true;
        }
    }
}