<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="HealthyAndTestyPresentation.test" %>

<%@ Register Src="~/UserControls/HeaderWebUserControl.ascx" TagPrefix="uc1" TagName="HeaderWebUserControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
<!-- pop-up -->
<link href="css/popuo-box.css" rel="stylesheet" type="text/css" media="all" />
<!-- //pop-up -->
<link rel="stylesheet" type="text/css" href="Content/zoomslider.css" />
<link rel="stylesheet" type="text/css" href="Content/style.css" />
<link href="Content/font-awesome.css" rel="stylesheet"/> 
<link href='//fonts.googleapis.com/css?family=Tangerine:400,700' rel='stylesheet' type='text/css'/>
<link href="//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i" rel="stylesheet"/>
<link href='//fonts.googleapis.com/css?family=Montserrat:400,700' rel='stylesheet' type='text/css'/>
</head>
<body>
    <form id="form1" runat="server">


        <div class="inner-header-agile">
            <nav class="navbar navbar-default">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <h1><a href="index.html"><span>h</span>ealthy 
                        <p class="s-log">&amp; tasty</p>
                    </a>

                    </h1>
                </div>
                <!-- navbar-header -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">

                    <ul class="nav navbar-nav">
                        <li><a href="index.html">Home</a></li>
                        <li class="active"><a href="about.html">About</a></li>
                        <li><a href="gallery.html">Gallery</a></li>
                        <li class="dropdown">
                            <a href="codes.html" class="dropdown-toggle hvr-bounce-to-bottom" data-hover="Pages" data-toggle="dropdown" aria-expanded="false">Pages <b class="caret"></b></a>
                            <ul class="dropdown-menu" style="display: none;">
                                <li><a href="icons.html">sign up</a></li>

                                <li><a href="codes.html">login</a></li>
                            </ul>
                        </li>

                        <li><a href="contact.html">Contact</a></li>


                    </ul>


                </div>
                <div class="clearfix"></div>
            </nav>
            <div class="w3ls_search">
                <div class="cd-main-header">
                    <ul class="cd-header-buttons">
                        <li><a class="cd-search-trigger" href="#cd-search"><span></span></a></li>
                    </ul>
                    <!-- cd-header-buttons -->
                </div>
                <div id="cd-search" class="cd-search">
                    <form action="#" method="post">
                        <input name="Search" type="search" placeholder="Search...">
                    </form>
                </div>
            </div>

        </div>


    </form>
</body>
</html>
