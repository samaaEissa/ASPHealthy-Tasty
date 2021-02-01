<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDiet.aspx.cs" Inherits="HealthyAndTestyPresentation.AddDiet" %>

<%@ Register Src="~/UserControls/AdminHeader.ascx" TagPrefix="uc1" TagName="AdminHeader" %>
<%@ Register Src="~/UserControls/AddDietWebUserControl.ascx" TagPrefix="uc1" TagName="AddDietWebUserControl" %>
<%@ Register Src="~/UserControls/FooterWebUserControl.ascx" TagPrefix="uc1" TagName="FooterWebUserControl" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Validation_JS.js" defer="defer"></script>
     <link href="main.css" rel="stylesheet" />
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
        <uc1:AdminHeader runat="server" ID="AdminHeader" />
        <uc1:AddDietWebUserControl runat="server" ID="AddDietWebUserControl" />
        <uc1:FooterWebUserControl runat="server" ID="FooterWebUserControl" />
    </form>
</body>
</html>