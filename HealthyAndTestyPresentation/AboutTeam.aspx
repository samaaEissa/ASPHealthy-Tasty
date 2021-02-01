<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutTeam.aspx.cs" Inherits="HealthyAndTestyPresentation.AboutTeam" %>

<%@ Register Src="~/UserControls/HeaderWebUserControl.ascx" TagPrefix="uc1" TagName="HeaderWebUserControl" %>
<%@ Register Src="~/UserControls/AboutTeam.ascx" TagPrefix="uc1" TagName="AboutTeam" %>
<%@ Register Src="~/UserControls/FooterWebUserControl.ascx" TagPrefix="uc1" TagName="FooterWebUserControl" %>
<%@ Register Src="~/UserControls/UserHeader.ascx" TagPrefix="uc1" TagName="UserHeader" %>
<%@ Register Src="~/UserControls/AdminHeader.ascx" TagPrefix="uc1" TagName="AdminHeader" %>






<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
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
    <link href="main.css" rel="stylesheet" />
    
   
    <title>H&T_TEST</title>
</head>
<body>
    <form  runat="server">
        <uc1:HeaderWebUserControl runat="server" ID="HeaderWebUserControl" />
        <uc1:UserHeader runat="server" ID="UserHeader"  Visible="false" />
        <uc1:AdminHeader runat="server" ID="AdminHeader"  Visible="false" />
        <uc1:AboutTeam runat="server" ID="AboutTeam1" />
        <uc1:FooterWebUserControl runat="server" ID="FooterWebUserControl" />

    </form>
</body>
</html>
