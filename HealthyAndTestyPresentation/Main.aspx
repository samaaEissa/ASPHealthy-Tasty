<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="HealthyAndTestyPresentation.Main" %>

<%@ Register Src="~/UserControls/HeaderWebUserControl.ascx" TagPrefix="uc1" TagName="HeaderWebUserControl" %>
<%@ Register Src="~/UserControls/AboutWebUserControl.ascx" TagPrefix="uc1" TagName="AboutWebUserControl" %>
<%@ Register Src="~/UserControls/MenueWebUserControl.ascx" TagPrefix="uc1" TagName="MenueWebUserControl" %>

<%@ Register Src="~/UserControls/RegisterWebUserControl.ascx" TagPrefix="uc1" TagName="RegisterWebUserControl" %>
<%@ Register Src="~/UserControls/AddDietWebUserControl.ascx" TagPrefix="uc1" TagName="AddDietWebUserControl" %>
<%@ Register Src="~/UserControls/AddMealWebUserControl.ascx" TagPrefix="uc1" TagName="AddMealWebUserControl" %>
<%@ Register Src="~/UserControls/AboutTeam.ascx" TagPrefix="uc1" TagName="AboutTeam" %>
<%@ Register Src="~/UserControls/FooterWebUserControl.ascx" TagPrefix="uc1" TagName="FooterWebUserControl" %>
<%@ Register Src="~/UserControls/ScrollSlidWebUserControl.ascx" TagPrefix="uc1" TagName="ScrollSlidWebUserControl" %>
<%@ Register Src="~/UserControls/AdminHeader.ascx" TagPrefix="uc1" TagName="AdminHeader" %>
<%@ Register Src="~/UserControls/UserHeader.ascx" TagPrefix="uc1" TagName="UserHeader" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <link href="main.css" rel="stylesheet" /> 
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Validation_JS.js" defer="defer"></script>    
    <link href="style.css" rel="stylesheet" />
   <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
    <link href="register_style.css" rel="stylesheet" />
    <script src="Scripts/WebForms/fontawesome.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Baloo+2&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Indie+Flower&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Amiri|Lobster+Two&display=swap" rel="stylesheet"/>
      
    <title>H&T_TEST</title>
</head>
<body>
    <form  runat="server">
    <uc1:AdminHeader runat="server" id="AdminHeader" Visible="false"/>
    <uc1:UserHeader runat="server" id="UserHeader" Visible="false"/>
    <uc1:HeaderWebUserControl runat="server" ID="HeaderWebUserControl" />
    
   
    <uc1:AboutWebUserControl runat="server" id="AboutWebUserControl" />
    
    <uc1:AboutTeam runat="server" id="AboutTeam" />
    <uc1:FooterWebUserControl runat="server" ID="FooterWebUserControl" />
    </form>
</body>
</html>
