<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminHeader.ascx.cs" Inherits="HealthyAndTestyPresentation.UserControls.AdminHeader" %>
<style>
    
    .topnav {
    overflow: hidden;
    background-color: black;
    display: block;
    font-size: 20px;
    opacity:0.8;
}

    .topnav a {
        float: right;
        display: inline;
        color: white;
        text-align: center;
        padding: 10px;
        background-color: black;
        text-decoration: none;
        margin: 10px;
    }

em {
    float: left;
    color:#39A0ED;
    padding: 10px;
    align-content: center-right;
    font-size:1rem;
}

.topnav a:hover {
    background-color: #39A0ED;
    color: white;
    

    margin: 10px;
}
 header {
         font-family: 'Baloo 2', cursive;
    background-image: linear-gradient(rgba(255,255,255,0.0),rgba(255,255,255,0.0)), url('imag/1.jpg');
    background-position: center;
    background-size: cover;
    background-attachment: fixed;
        height: 650px;
        margin: 0px;
    }
</style>
<header id="header">
<div class="topnav">
   
    <a href="../AboutTeam.aspx">About Team</a>
    <a href="../AboutUs.aspx">About US</a>
    <a href="../Registeration.aspx">Add User</a> 
    <a href="../AddMeal.aspx">Add Meal</a>
    <a href="../AddDiet.aspx">Add Diet</a>
    <a href="../Meanue.aspx">Meals</a>
    <a href="#" id="btn_logout" runat="server" onserverclick="btn_logout_ServerClick">Log Out</a>
<p ><em><img src="../imag/grape.png" style="width:50px; height:50px;" /></em></p>
</div><div class=" text-center">
                        <h1 class="text-center text-uppercase display-3 ">
                            <small>clever meals</small> <br />
                            <strong class="primary-color"> healthy & tasty</strong>
                        </h1>
                        
                    </div>
</header>