<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddMealWebUserControl.ascx.cs" Inherits="HealthyAndTestyPresentation.UserControls.AddMealWebUserControl" %>
<section id="AddMeal"  >
    <div class="flex-container py-5 my-5">
        <div class="row ">
            <div class="col-md-3"></div>
          <div class=" col-md-6" style="background:rgba(255,255,255,0.5);margin-top:60px;height:550px; border-radius:5px;">  
        <div>
            <img src="imag/iconfinder_fruiticons_buttons_grape_1844710.png" />
            <h1 style="display:inline;">New Meal</h1>
        </div>
        <div class="flex-container">
            <div class="row">
                 <div class="col-md-6">
             <input id="txtMName" type="text" clientidmode="static" class="form-control"  runat="server" placeholder="Enter meal's name" />
                      </div>
                <div class="col-md-6">
            <input id="txtPrice" type="text"  clientidmode="static" class="form-control"  runat="server"  placeholder="Enter meal's price" />
                    </div> </div>
             <div class="row">
                 <div class="col-md-6">
            <select id="SelectMealType" clientidmode="static"  class="form-control" runat="server" >
                <option disabled="disabled" value="-1" selected="selected">Meal Type</option>
                <option value="1"></option>
                <option value="2"></option>
                <option value="3"></option>
                <option value="4"></option>

            </select>
                     </div>
                <div class="col-md-6">
            <asp:DropDownList ID="SelectDiet" clientidmode="static" class="form-control" runat="server">

            </asp:DropDownList>
            </div> </div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <textarea id="TAMealingrediants" clientidmode="static" rows="2" cols="70" runat="server" class="form-control" placeholder="Enter the ingrediants "></textarea>
            <input type="submit" id="btn_AddMeal" class="btn btn-info    text-capitalize" runat="server"  clientidmode="static"  onclick="return(validatMeal());"  onserverclick="btn_AddMeal_ServerClick" value="Add Meal" />
        </div>

  </div>
            <div class="col-md-3"></div>
        </div>
        </div></section>