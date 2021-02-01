using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthyAndTestyPresentation
{
    public partial class AboutTeam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["admin"] != null)
                {
                    AdminHeader.Visible = true;
                    HeaderWebUserControl.Visible = false;


                }
                else if (Session["user"] != null)
                {
                    UserHeader.Visible = true;
                    HeaderWebUserControl.Visible = false;

                }

            }

        }
    }
}