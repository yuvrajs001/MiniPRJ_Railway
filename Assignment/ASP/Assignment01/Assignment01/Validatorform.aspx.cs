using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment01
{
    public partial class Validatorform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

            string familyName = familyNameTextBox.Text;
            string name = nameTextBox.Text;


            if (familyName.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                // If the family name is the same as the name, validation fails
                args.IsValid = false;
            }
            else
            {
                // If the family name differs from the name, validation succeeds
                args.IsValid = true;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (IsValid)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "checkDetails", "checkDetails();", true);
                lbl.Visible = true;
                lbl.Text = "Form submitted successfully!";
            }

        }

    }
}
