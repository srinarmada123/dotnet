using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_social_media
{
    public partial class WebForm1 : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            //ddlYears.Items.Add("..YEAR..");
            //for(short year=1950;year<=2200;year++)
            //{                
            //    ddlYears.Items.Add(Convert.ToString(year));
            //}
            //ddlMonths.Items.Add("..MONTHS..");
            //for (byte month = 1; month <= 12; month++)
            //{
            //    ddlMonths.Items.Add(Convert.ToString(month));
            //}
            if (!IsPostBack)
            {
                Random r = new Random();
                Literal1.Text = (r.Next(1000, 9999)).ToString();                
            }            
        }
        protected void ddlDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddlMonths.SelectedItem.Text == "2" && Convert.ToByte(ddlDates.SelectedItem.Text) > 28)
            //{
            //    Response.Write("<script>alert('Please select valid date')</script>");
            //    return;
            //}
        }

        protected void ddlMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ddlDates.Items.Clear();
            //if (ddlMonths.SelectedItem.Text == "2")
            //{             
            //    ddlDates.Items.Add("..DATES..");
            //    for (byte day = 1; day <= 28; day++)
            //    {
            //        ddlDates.Items.Add(Convert.ToString(day));                    
            //    }
            //}
            //else if (ddlMonths.SelectedItem.Text == "1" || ddlMonths.SelectedItem.Text == "3" || ddlMonths.SelectedItem.Text == "5" || ddlMonths.SelectedItem.Text == "7" || ddlMonths.SelectedItem.Text == "8" || ddlMonths.SelectedItem.Text == "10" || ddlMonths.SelectedItem.Text == "12")
            //{             
            //    ddlDates.Items.Add("..DATES..");
            //    for (byte day = 1; day <= 31; day++)
            //    {
            //        ddlDates.Items.Add(Convert.ToString(day));
            //    }
            //}
            //else
            //{                
            //    ddlDates.Items.Add("..DATES..");
            //    for (byte day = 1; day <= 30; day++)
            //    {
            //        ddlDates.Items.Add(Convert.ToString(day));
            //    }
            //}
        }
        EL el = new EL();
        protected void cmdbutton_Click(object sender, EventArgs e)
        {
            if (Literal1.Text == txtCaptch.Text)
            {
                el.FIRSTNAME = txtFirstName.Text;
                el.LASTNAME = txtLastName.Text;
                el.EMAILORPHONE = txtEmailPhone.Text;
                el.DOB = Convert.ToDateTime(txtDOB.Text);
                Response.Redirect("Registration.aspx");
                //Response.Write("<script>alert('Registered successfully')</script>");

            }
            else
            {
                Response.Write("<script>alert('Invalid Captch')</script>");
            }
        }
    }
}