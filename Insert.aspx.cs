using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospital_Management_Database
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DoctorIn");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PatientIn");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/EmployeeIn");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DiseaseIn");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MedicineIn");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RecordIn");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admission_Release");
        }
    }
}