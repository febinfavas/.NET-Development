using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void getButton_Click(object sender, EventArgs e) {
            resultLabel.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void setButton_Click(object sender, EventArgs e) {
            Calendar1.SelectedDate = DateTime.Parse("15/06/2021");
            Calendar1.VisibleDate = Calendar1.SelectedDate;
        }


        protected void Calendar1_SelectionChanged(object sender, EventArgs e) {
            resultLabel.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void diffButton_Click(object sender, EventArgs e) {
            if (Calendar1.SelectedDate > Calendar2.SelectedDate)
            {
                diffLabel.Text = Calendar1.SelectedDate.Subtract(Calendar2.SelectedDate).TotalDays.ToString();
            }
            else
            {
                diffLabel.Text = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate).TotalDays.ToString();
            }
        }

        protected void subButton_Click(object sender, EventArgs e) {
            resultLabel3.Text = "You Selected this Dates: <br />";

            resultLabel3.Text += Calendar3.SelectedDate.ToLongDateString() + "<br />";

            resultLabel3.Text += "Times : " + timeList.Text;
        }

        protected void Calendar3_DayRender(object sender, DayRenderEventArgs e) {
            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
            }
        }

        protected void Calendar3_SelectionChanged(object sender, EventArgs e) {
            timeList.Items.Clear();

            switch (Calendar3.SelectedDate.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    timeList.Items.Add("10:00");
                    timeList.Items.Add("11:00");
                    timeList.Items.Add("12:00");
                    break;
                default:
                    timeList.Items.Add("10:00");
                    timeList.Items.Add("11:00");
                    timeList.Items.Add("12:00");
                    timeList.Items.Add("13:00");
                    timeList.Items.Add("14:00");
                    timeList.Items.Add("15:00");
                    break;
            }
        }

        protected void loginButton_Click(object sender, EventArgs e) {
            string QueryString = "";
            QueryString = "?q=" + loginTextBox1.Text ;

            Session["pw"] = passTextBox2.Text;

            Response.Redirect("calender.aspx"+ QueryString);

        }
    }
}