<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddDietWebUserControl.ascx.cs" Inherits="HealthyAndTestyPresentation.UserControls.AddDietWebUserControl" %>
<section id="AddDiet"  >
    <div class="flex-container py-5 my-5">
        <div class="row ">
              <div class="col-md-3"></div>
          <div class="  col-md-6" style="background:rgba(255,255,255,0.5);margin-top:60px;height:650px; border-radius:5px;">   

        <div>
            <img src="imag/iconfinder_fruiticons_buttons_grape_1844710.png" />
            <h1 style="display:inline;"> New Diet</h1>
        </div>
        <div class="flex-container">
             <div class="row">
                 <div class="col-md-6">
            <input id="txtDName" runat="server" clientidmode="static" class="form-control" type="text" placeholder="Enter Diet Name" />
                      </div>
                <div class="col-md-6">
            <input id="txtCarbs"  runat="server" clientidmode="static" class="form-control" type="text" placeholder="Enter carb percentage" />
                     </div> </div>
            <div class="row">
                 <div class="col-md-6">
            <input id="txtProutin" runat="server" clientidmode="static" type="text" class="form-control" placeholder="Enter Proutin percentage" />
                     </div>
                <div class="col-md-6">
            <input id="txtVitamin" runat="server" clientidmode="static" type="text" class="form-control" placeholder="Enter Vitamin percentage" />
                     </div> </div>
            <div class="row">
                 <div class="col-md-6">
            <input id="txtMinerals" runat="server"  clientidmode="static" type="text"  class="form-control" placeholder="Enter Minerals percentage" />
                      </div>
                <div class="col-md-6">
            <input id="txtFat" type="text" runat="server" clientidmode="static" class="form-control"  placeholder="Enter Fat percentage" />
                     </div> </div>
            <textarea id="TADescription" clientidmode="static" runat="server" class="form-control" rows="2" cols="70" placeholder="Enter the description "></textarea>
           
            <input type="submit"  class="btn btn-info    text-capitalize"  id="btn_AddDiet" runat="server"  onclick="return (validatDiet());"  clientidmode="static" onserverclick="btn_AddDiet_ServerClick"  value="Add Diet" />
            
        </div></div>
              <div class="col-md-3"></div>
    <%--</form>--%></div>
        </div></section>