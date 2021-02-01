using HealthyANDTastyBusiness.Managers;
using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthyAndTestyPresentation.UserControls
{
    public partial class RegisterWebUserControl : System.Web.UI.UserControl
    {
        UserManager userManager = new UserManager();
        private UnitOfWork unitOfWork = new UnitOfWork();
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_ServerClick(object sender, EventArgs e)
        {
            try
            {
                user.fullName = txtName.Value;
                user.phone = txtPhone.Value;
                user.password = txtPassword.Value;
                user.address = txtAddress.Value;
                user.e_mail = txtEmail.Value;
                user.medicalState = medicalConditionSelect.Value;
                user.weight = double.Parse(txtWeight.Value);
                user.hight = double.Parse(txtHeight.Value);

                userManager.UserRegisteration(user);

                //Session["user"] = user;
                //Response.Redirect("Main.aspx");

                Response.Write("<script>alert('welcome to healthy & tasty');</script>");

               

            }
            catch (Exception exp)
            {
                
            }

        }
    }
}