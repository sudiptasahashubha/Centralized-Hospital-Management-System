using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_Database
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DoctorDel");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PatientDel");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeDel");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DiseaseDel");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MedicineDel");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admission_ReleaseDel");
        }
    }
}