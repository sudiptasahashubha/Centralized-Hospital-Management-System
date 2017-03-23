using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_Database
{
    public partial class SuperAdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals("Super"))
            {
                Response.Redirect("~/Choice");
            }
            else
            {
                Response.Write("WRONG PASSWORD!!!");
            }
            
        }
    }
}