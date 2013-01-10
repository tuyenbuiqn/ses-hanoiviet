<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true" CodeBehind="VideoDetail.aspx.cs" Inherits="SES.VTTEN.WEB.VideoDetail" Title="Untitled Page" %>
<%@ Register Src="Module/ucTourCateLeftMenu.ascx" TagName="ucTourCateLeftMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSearchTour.ascx" TagName="ucSearchTour" TagPrefix="uc2" %>
<%@ Register Src="Module/ucSendContact.ascx" TagName="ucSendContact" TagPrefix="uc3" %>
<%@ Register Src="Module/ucRelatedTour.ascx" TagName="ucRelatedTour" TagPrefix="uc4" %>
<%@ Register Src="Module/ucHotTours.ascx" TagName="ucHotTours" TagPrefix="uc5" %>
<%@ Register Src="Module/ucTopStarRatesHotels.ascx" TagName="ucTopStarRatesHotels"
    TagPrefix="uc6" %>
<%@ Register Src="Module/ucLeftBanner.ascx" TagName="ucLeftBanner" TagPrefix="uc7" %>
<%@ Register src="Module/ucRightBanner.ascx" tagname="ucRightBanner" tagprefix="uc8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/css/tourstyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div id="Panel">
        <div class="menuleftmain1">
            <uc1:ucTourCateLeftMenu ID="ucTourCateLeftMenu1" runat="server" />
            <uc7:ucLeftBanner ID="ucLeftBanner1" runat="server" />
        </div>
        <div class="left-content">
            <div class="content">
                <h1>
                    <h1><asp:Label runat="server" ID="lblAlbum"></asp:Label></h1>
                </h1>
                 <div class="thinline7">
                </div>
                <asp:Repeater ID="rptImages" runat="server">
                    <ItemTemplate>
                        <div class="Album-video">
                            <div class="Album-Cover-video">
                                <a class="fancybox-media" title='<%#Eval("Title") %>' href='http://www.youtube.com/watch?v=<%#Eval("Url") %>'>
                                    <img src='http://i4.ytimg.com/vi/<%#Eval("Url") %>/default.jpg' height="120px" width="180px" title='<%#Eval("Title") %>' alt='<%#Eval("Title")%>' />
                                </a>
                            </div>
                            <div class="Album-Title-video" style="text-align: center;">
                                    <%#Eval("Title")%>
                                
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            
        </div>
        <div class="mainR">
            <uc2:ucSearchTour ID="ucSearchTour1" runat="server" />
            <uc3:ucSendContact ID="ucSendContact1" runat="server" />
            <uc5:ucHotTours ID="ucHotTours1" runat="server" />
            <uc8:ucRightBanner ID="ucRightBanner1" runat="server" />
        </div>
        <!----- ### End Right Main ### ----->
    </div>
</asp:Content>
