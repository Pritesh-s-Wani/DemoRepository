﻿<%@ Page Title="" Language="VB" AutoEventWireup="false" CodeFile="login_pg.aspx.vb" Inherits="login_pg" %>


<!--Author: W3layouts
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE HTML>
<html>
<head>
    <title>Shoppy an Admin Panel Category Flat Bootstrap Responsive Website Template | Login :: w3layouts</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Shoppy Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all">
    <!-- Custom Theme files -->
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--js-->
    <script src="js/jquery-2.1.1.min.js"></script>
    <!--icons-css-->
    <link href="css/font-awesome.css" rel="stylesheet">
    <!--Google Fonts-->
    <link href='//fonts.googleapis.com/css?family=Carrois+Gothic' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Work+Sans:400,500,600' rel='stylesheet' type='text/css'>
    <!--static chart-->
</head>
<body>
    <div class="login-page">
        <div class="login-main">
            <div class="login-head">
                <h1>Login</h1>
            </div>
            <div class="login-block">
                <form id="loginfrm" runat="server">
                    <%--<input type="text" name="email" placeholder="Email" required="">
					<input type="password" name="password" class="lock" placeholder="Password">--%>
                    <asp:TextBox ID="txtmail" runat="server" placeholder="Email" required=""></asp:TextBox>
                    <asp:TextBox ID="txtpass" runat="server" placeholder="Password" TextMode="Password" Class="lock" required=""></asp:TextBox>
                    <%--<input type="submit" name="Sign In" value="Login">--%><asp:Button  ID="btnlogin" runat="server" text="Login"/>
                    <h3>Not a member?<a href="signup.html"> Sign up now</a></h3><br />
                    <h3><asp:Label Font-Bold="true" ForeColor="Red" ID="lblerr" runat="server" ></asp:Label></h3>


                </form>

            </div>
        </div>
    </div>
    <!--inner block end here-->
    <!--copy rights start here-->

    <!--COPY rights end here-->

    <!--scrolling js-->
    <script src="js/jquery.nicescroll.js"></script>
    <script src="js/scripts.js"></script>
    <!--//scrolling js-->
    <script src="js/bootstrap.js"> </script>
    <!-- mother grid end here-->
</body>
</html>




