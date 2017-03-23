using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_Database
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DoctorUp");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PatientUp");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeUp");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admission_ReleaseUp.aspx");
        }
    }
}