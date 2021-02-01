<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HealthyAndTestyPresentation.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
     <script src="Scripts/jquery.magnific-popup.js"></script>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="test.js" defer="defer"></script>
    <link href="https://fonts.googleapis.com/css?family=Baloo+2&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Indie+Flower&display=swap" rel="stylesheet"/>
   <link href="https://fonts.googleapis.com/css?family=Amiri|Lobster+Two&display=swap" rel="stylesheet"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
    <link href="loginStyle.css" rel="stylesheet" />
</head>
<body class="log_form">

    <form id="form1" runat="server" >
      <div class="container">
    <div class="row">
        <div class="col-md-3"></div>
           <div class="col-md-6" style="background:rgba(255,255,255,0.5);margin-top:60px;height:500px;">
   <div><h1>
      <img src="imag/iconfinder_fruiticons_buttons_grape_1844710.png" />
       login </h1>
   </div>
       
       
             <div class="container">
             
      
                    <asp:TextBox ID="tb_userName" placeholder="UserName" runat="server" class="form-control" ></asp:TextBox>
                    <asp:TextBox  ID="tb_password"  placeholder="Password" runat="server" TextMode="Password"  class="form-control"></asp:TextBox>
                    <asp:Button ID="submit"  class="btn btn-info    text-capitalize" runat="server" Text="Submit" OnClientClick="return (validateLogin());"  OnClick="submit_Click" />
                
            </div></div>
           <div class="col-md-3"></div>
         </div>
         </div>
      
    </form>
</body>
</html>
