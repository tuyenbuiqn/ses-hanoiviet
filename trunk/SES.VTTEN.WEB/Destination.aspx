<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true" CodeBehind="Destination.aspx.cs" Inherits="SES.VTTEN.WEB.Destination" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
                    <asp:Label runat="server" ID="lblDestinationName" Text=""></asp:Label>
                </h1>
                <div class="thinline7">
                </div>
                <div class="img_hotel1">
                    <div class="gallery galNoMargin gallhotelDetails">
                        <div class="thumbs galleryFB">
                            <asp:Repeater ID="rpImage" runat="server">
                                <ItemTemplate>
                                    <a class="fancybox-tourimg" rel="tourimg" title="<%#Eval("Title") %>" href="/Media/<%#Eval("MediaFile") %>">
                                        <img src="/Media/<%#Eval("MediaFile") %>" alt="<%#Eval("Title") %>">
                                    </a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="mainPic">
                            <a class="fancybox-tourimg" id="hplMainIMG" rel="tourimg" title="" href="" runat="server">
                                <asp:Image ID="ImgTour" Width="378px" Height="220px" runat="server" />
                            </a>
                        </div>
                    </div>
                </div>
                
                <div class="contentourdt1">
                    <asp:Label runat="server" ID="lblDescription" Text=""></asp:Label>
                </div>
                <div class="toursub2">
                    <h3>
                        RELATED TOUR</h3>
                </div>
                <div class="toursub2">
                    <asp:Repeater runat="server" ID="rptRelatedTour">
                        <ItemTemplate>
                            <div class="toursub12">
                <div class="in1toursub10">
                    <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' title='<%#Eval("Title")%>'>
                        <%#Eval("Title")%>
                    </a>
                </div>
                <div class="in2toursub10">
                    <%#Eval("TourCode") %></div>
                <div class="in3toursub10">
                    Price:</div>
                <div class="in4toursub10">
                    US $<%#Eval("TourPrice") %></div>
            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <div class="mainR">
            <uc2:ucSearchTour ID="ucSearchTour1" runat="server" />
            <uc3:ucSendContact ID="ucSendContact1" runat="server" />
            <%--  <div class="modul2">
                <div class="modul1in">
                    <div class="titmodul1">
                        Hot Promotion</div>
                </div>
                <div class="modul1list">
                    <ul>
                        <li><a href="http://www.southpacifictravel.com.vn/tours/indochina_tours/152/Halong_Bai_Tu_Long_junk.aspx">
                            Halong Bai Tu Long junk </a></li>
                    </ul>
                </div>
            </div>--%>
            
            <uc6:ucTopStarRatesHotels ID="ucTopStarRatesHotels1" runat="server" />
            <uc5:ucHotTours ID="ucHotTours1" runat="server" />
            <uc8:ucRightBanner ID="ucRightBanner1" runat="server" />
        </div>
        <!----- ### End Right Main ### ----->
    </div>
</asp:Content>

