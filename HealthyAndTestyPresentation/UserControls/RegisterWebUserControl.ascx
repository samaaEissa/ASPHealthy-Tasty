<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterWebUserControl.ascx.cs" Inherits="HealthyAndTestyPresentation.UserControls.RegisterWebUserControl" %>
<section id="register"  >
    <div class="flex-container py-5 my-5">
        <div class="row py-5 my-5">
             <div class="col-md-3"></div>
     <div class=" col-md-6 " style="background:rgba(255,255,255,0.5);margin-top:60px;height:550px; border-radius:5px;" >
        <div class="col-md">
            <img src="imag/Signup-logotype-V1.png" />
        </div>
        <div class="flex-container">
            <div class="row">
                 <div class="col-md-6">
            <input id="txtName" type="text" clientidmode="static" class="form-control" runat="server" placeholder="Enter Your Name" />
                     </div>
                <div class="col-md-6">
            <input id="txtEmail"  type="text" clientidmode="static" class="form-control" runat="server" placeholder="Enter Your email" />
               </div> </div>
            <div class="row">
                 <div class="col-md-6">
            <input id="txtPhone" type="text" clientidmode="static" class="form-control" runat="server" placeholder="Enter Your phone" />
                     </div>
                <div class="col-md-6">
            <input id="txtAddress" type="text" clientidmode="static" class="form-control"  runat="server" placeholder="Enter Your address" />
                    </div> </div>
            <div class="row">
                 <div class="col-md-6">
            <input id="txtWeight" type="text" clientidmode="static"  class="form-control" runat="server"  placeholder="Enter Your weight" />
                      </div>
                <div class="col-md-6">
            <input id="txtHeight" type="text" clientidmode="static" class="form-control" runat="server"  placeholder="Enter Your height" />
                    </div> </div>
            <div class="row">
                 <div class="col-md-6">
            <input id="txtPassword" type="password" clientidmode="static" runat="server" class="form-control"  placeholder="Enter Your password" />
             </div>
                <div class="col-md-6">
            <select id="medicalConditionSelect"  class="form-control"   clientidmode="static" runat="server">
                <option disabled="disabled" value="-1" selected="selected">medical condition</option>
                <option value="1">Healthy</option>
                <option value="2">Diabetic</option>
                <option value="3">Hypertention</option>
                

            </select></div> </div>
            <div class="row">
            <input  type="submit" class="btn btn-info    text-capitalize" id="btn_register" clientidmode="static" runat="server" onclick="return (ValidatRegisterationInputs());" onserverclick="btn_register_ServerClick" value="Sign up" />
        </div> </div>
            </div>
       <div class="col-md-3"></div> 
        </div>
        </div></section>