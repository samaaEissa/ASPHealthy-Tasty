using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthyAndTestyPresentation
{
    public partial class login : System.Web.UI.Page
    {
       private UnitOfWork unitOfWork = new UnitOfWork();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string userName = tb_userName.Text;
            string password = tb_password.Text;
            Admin admin =  unitOfWork.AdminRepository.checkAdminExist(userName, password);
            if(admin!=null)
            {
                Session["admin"] = admin;
                Response.Redirect("Main.aspx");
            }
            else
            {
                User user= unitOfWork.UserRepository.Checkuser(userName, password);
               if(user!=null)
                {
                    Session["user"] = user;
                    Response.Redirect("Main.aspx");
                }
            }

        }
    }
}