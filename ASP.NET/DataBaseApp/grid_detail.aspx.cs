using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBaseApp
{
    public partial class grid_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) {
            DetailsView1.PageIndex = GridView1.SelectedIndex;
        }
    }
}