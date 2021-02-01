<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenueWebUserControl.ascx.cs" Inherits="HealthyAndTestyPresentation.UserControls.MenueWebUserControl" %>
 <section id="menue" class=" py-5  px-5">


        <div class="flex-container ">
            <h1 class="text-center text-uppercase display-3 ">

                <img src="imag/iconfinder_restaurant_menu_93247.png" />
                Menu
            </h1>
            <div id="Meals_Container" class="row ">

                 
                    <asp:Repeater ID="mealsRepeater" runat="server">
                        <ItemTemplate>                           
                            <div id="singleMealDiv"  runat="server" onclick="addSelectedStyle(this);getSelectedItemId(this);" class="single-item   col-md-4 ">
                                <div class="row">
                                <input value="<%#Eval("mealId") %>" type="text" style="display:none" />
                                <div class="single-item-text   ">
                                    <h2 > <img src="<%#Eval("ImageURl") %>" /> <%#Eval("  "+"Mname") %> </h2>
                                    <h6 class="text-muted">
                                       
                                        <%#Eval("ingrdiants") %>
                                       </h6>
                                </div>
                                <div  class="price">
                                    <h3 class="text-uppercase   " ><%#Eval("price") %>$</h3>
                                </div>
                               
                            </div></div>

                        </ItemTemplate>
                    </asp:Repeater>
                <asp:HiddenField ID="SelectedMealsHF" runat="server" ClientIDMode="Static" />
                
                 
        </div>
             <div  class="row">
                  <div class="col-md-3"></div>
                     <input  type="button" runat="server"  class="btn btn-info    text-capitalize"  onserverclick="btn_order_ServerClick"  id="btn_order" clientidmode="static"    value="order now"  />
                 <div class="col-md-3"></div>
             </div>
             </div>

    </section>
<script>
    function SelectedState(item) {
        var IsSelected = false
        var classList = $(item).attr('class').split(/\s+/);
        $.each(classList, function (index, item) {
            if (item === 'selected') {
                IsSelected = true;
            }
        });
        return IsSelected;

    }

  

    function getSelectedItemId(item) { 
        var innerDiv = $(item).children("div:first")
        var ItemId = $(innerDiv).children("input[type='text']:first").val();
        var SelectedMealsHFValue = $('#SelectedMealsHF').val();       
        if (SelectedMealsHFValue.search(ItemId) > 0) {            
            SelectedMealsHFValue = SelectedMealsHFValue.replace(ItemId + ",", '');
            $('#SelectedMealsHF').val(SelectedMealsHFValue);
        }
        else {
            //Add Value to SelectedMealsHFValue
            if (SelectedMealsHFValue == "")
                SelectedMealsHFValue = ItemId
            else
                SelectedMealsHFValue = SelectedMealsHFValue + "," + ItemId;
            $('#SelectedMealsHF').val(SelectedMealsHFValue);
        }
    }
   
   

    function addSelectedStyle(item) {
        var Selected = SelectedState(item);
        if (Selected) {
            $(item).removeClass("selected");
        }
        else {
            $(item).addClass("selected")
        }
    }
</script>