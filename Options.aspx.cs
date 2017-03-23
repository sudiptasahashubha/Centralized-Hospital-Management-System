using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_Database
{
    public partial class Options : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void QueryButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Query");
        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Insert");
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Update");
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Delete");
        }
    }
}