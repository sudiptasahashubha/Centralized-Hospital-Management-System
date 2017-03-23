using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_Database
{
    public partial class Query : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Doctor.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Patient.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Medicine.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Disease.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Record.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employee.aspx");

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DoctorSpec");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeSpec");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DoctorPat");
        }

    }
}