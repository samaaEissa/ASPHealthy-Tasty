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
    public partial class AddMealWebUserControl : System.Web.UI.UserControl
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<Diet> diets = unitOfWork.DietRepository.GetAll();
            SelectDiet.DataSource = diets;
            SelectDiet.DataTextField = "DietName";
            SelectDiet.DataValueField = "DietID";
            SelectDiet.DataBind();
        }

        protected void btn_AddMeal_ServerClick(object sender, EventArgs e)
        {
            try
            {

                Byte[] fileData = new Byte[FileUpload1.PostedFile.ContentLength];
                HttpPostedFile uploadedFile = FileUpload1.PostedFile;
                uploadedFile.InputStream.Read(fileData, 0, FileUpload1.PostedFile.ContentLength);

                Meal meal = new Meal();
                meal.DietID = int.Parse(SelectDiet.SelectedValue);
                meal.price = double.Parse(txtPrice.Value);
                meal.Mname = txtMName.Value;
                meal.ingrdiants = TAMealingrediants.Value;
                meal.type = SelectMealType.Value;
                meal.image = fileData;
                unitOfWork.MealRepository.Save(meal);
                unitOfWork.Commit();
                Response.Write("<script>alert('new meal has been added successfully');</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message+"');</script>");

            }
        }
    }
}