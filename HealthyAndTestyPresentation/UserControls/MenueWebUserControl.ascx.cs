using HealthyANDTastyBusiness.Managers;
using HealthyANDTastyDAL.Repositories;
using HealthyANDTastyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HealthyAndTestyPresentation.UserControls
{
    public partial class MenueWebUserControl : System.Web.UI.UserControl
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Meal> listMeal = new List<Meal>();
                if (Session["admin"] != null)
                {
                    listMeal = unitOfWork.MealRepository.GetAll();
                    btn_order.Visible = false;
                }
                else if (Session["user"] != null)
                {
                    btn_order.Visible = true;
                    User user = (User)Session["user"];
                    listMeal = unitOfWork.MealRepository.GetMealsByDietID(user.DietID);
                }
                foreach (var meal in listMeal)
                {
                    meal.ImageURl = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(meal.image));
                }
                mealsRepeater.DataSource = listMeal;
                mealsRepeater.DataBind();
            }

        }

        protected void btn_order_ServerClick(object sender, EventArgs e)
        {
            string SelectedMealsIds = SelectedMealsHF.Value;
            List<string> listMealsIds = SelectedMealsIds.Split(',').ToList();
            if (Session["user"]!=null)
            {
                double price = 0;
                OrderManager orderManager = new OrderManager();
                User user = (User)Session["user"];
                foreach(string mealId in listMealsIds)
                {
                    Order order = new Order();
                    order.CustomerID = user.customerID;
                    order.mealID = int.Parse(mealId);
                    orderManager.Ordering(order);
                    price+= unitOfWork.MealRepository.GetByID(int.Parse(mealId)).price;
                }
                SelectedMealsHF.Value = "";
                Response.Write("<script>alert('your order is on the way  the total price is "+price.ToString() +"');</script>");
            }
        }
    }
}