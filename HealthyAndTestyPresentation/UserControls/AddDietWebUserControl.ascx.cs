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
    public partial class AddDietWebUserControl : System.Web.UI.UserControl
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }   

        protected void btn_AddDiet_ServerClick(object sender, EventArgs e)
        {
            Diet diet = new Diet();
            diet.DietName = txtDName.Value;
            diet.DietDescription = TADescription.Value;
            diet.carbsPercent = int.Parse(txtCarbs.Value);
            diet.fatsPercent = int.Parse(txtFat.Value);
            diet.vitaminPercent = int.Parse(txtVitamin.Value);
            diet.mineralsPercent = int.Parse(txtMinerals.Value);
            diet.ProtienPercent = int.Parse(txtProutin.Value);
            unitOfWork.DietRepository.Save(diet);
            unitOfWork.Commit();
            Response.Write("<script>alert('a new diet has been added successfully');</script>");
        }
    }
}