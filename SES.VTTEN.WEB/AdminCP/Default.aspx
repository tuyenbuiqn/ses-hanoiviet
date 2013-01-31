<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SES.VTTEN.WEB.AdminCP.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>HanoiVietTravel - Administrator CP</title>   

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.3/jquery.min.js"></script>

    <!-- MASTER STYLESHEET-->
    <link href="css/styles.css" rel="stylesheet" type="text/css" />
    <!-- LOAD TIPSY TOOLTIPS-->

    <script type="text/javascript" src="js/jquery.tipsy.js"></script>

    <!-- LOAD CUSTOM JQUERY SCRIPTS-->

    <script type="text/javascript" src="js/scripts.js"></script>

    <!-- LOAD FACEBOX -->

    <script type="text/javascript" src="js/facebox.js"></script>

    <link href="css/facebox.css" rel="stylesheet" type="text/css" />
    <!-- LOAD FLOT GRAPHS -->

    <script type="text/javascript" src="js/jquery.flot.pack.js"></script>

    <script type="text/javascript" src="js/LoaiDau.js"></script>

    <!--[if IE]>
     <script language="javascript" type="text/javascript" src="js/excanvas.pack.js"></script>
    <![endif]-->
    <!--[if IE 6]>
    <script src="js/pngfix.js"></script>
    <script>
        DD_belatedPNG.fix('.png_bg');
    </script>        
    <![endif]-->
    <!-- LOAD GRAPH JAVASCRIPT FILE-->

    <script src="js/graphs.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <div id="header" class="png_bg">
        <div id="head_wrap" class="container_12">
            <!-- start of logo - you could replace this with an image of your logo -->
            <div id="logo" class="grid_4">
                &nbsp;</div>
            <!-- end logo -->
            <!-- start control panel -->
            <div id="controlpanel" class="grid_8">
                <div style="float: right">
                    <div style="float: right">
                        Xin chào: <strong>
                            <asp:Label ID="lblUsername" runat="server" Text="lblUsername"></asp:Label></strong>
                        - <a style="text-decoration: none; color: Black;" href="Login.aspx?Option=Logout">Thoát</a></p></div>
                </div>
            </div>
            <!-- end control panel -->
            <!-- start navigation -->
            <div id="navigation" class=" grid_12">
                <ul>
                    <li>
                        <asp:HyperLink ID="hplDestination" NavigateUrl="Default.aspx?Page=ListTour" runat="server">Điểm đến/Danh mục/Tour</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplHotel" NavigateUrl="Default.aspx?Page=Hotel" runat="server">Khách Sạn</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplNews" NavigateUrl="Default.aspx?Page=News" runat="server">News</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplService" NavigateUrl="Default.aspx?Page=Service" runat="server" Visible="false">Dịch vụ</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplContent" NavigateUrl="Default.aspx?Page=Content" runat="server">Thông tin</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplSupport" NavigateUrl="Default.aspx?Page=ChatContent" runat="server" Visible="false">Hỗ trợ trực tuyến</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplAdvert" NavigateUrl="Default.aspx?Page=Adverts" runat="server" Visible="false">Quảng cáo</asp:HyperLink></li>
                    <li>
                    <li><asp:HyperLink ID="hplAlbum" NavigateUrl="Default.aspx?Page=ListImgAlbum" runat="server">QL album</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplMedia" NavigateUrl="Default.aspx?Page=TourImages" runat="server">Hình ảnh - Video</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplConfig" NavigateUrl="Default.aspx?Page=ListUser" runat="server">Hệ thống</asp:HyperLink></li>
                    <li>
                        <asp:HyperLink ID="hplBooking" NavigateUrl="Default.aspx?Page=ListBooking" runat="server">Booking</asp:HyperLink></li>
                </ul>
            </div>
            <!-- end navigation -->
        </div>
        <!-- end headwarp  -->
    </div>
    <!-- end header -->
    <!-- start subnav -->
    <div id="sub_nav">
        <div id="subnav_wrap" class="container_12">
            <!-- start sub nav list -->
            <div id="subnav" class=" grid_12">
                <ul>
                    <asp:PlaceHolder ID="phSubNav" runat="server"></asp:PlaceHolder>
                </ul>
            </div>
            <!-- end subnavigation list -->
        </div>
    </div>
    <!-- end sub_nav -->
    <!-- START EVERYTING BELOW IS THE MAIN CONTENT -->
    <div class="container_12">
        <asp:PlaceHolder ID="phPageControl" runat="server"></asp:PlaceHolder>
        <div class="clearfix">
            &nbsp;</div>
    </div>
    <!-- END EVERYTING BELOW IS THE MAIN CONTENT -->
    <div class="clearfix">
        &nbsp;</div>
    <div class="container_12">
        <!-- START FOOTER -->
        <div id="footer" class="grid_12">
            <p>
                © Copyright 2010 hanoiviettravel.vn&nbsp;
                | <a href="#">Top</a></p>
        </div>
        <!-- END FOOTER -->
    </div>
    <!-- end content wrap -->
    </form>
</body>
</html>
