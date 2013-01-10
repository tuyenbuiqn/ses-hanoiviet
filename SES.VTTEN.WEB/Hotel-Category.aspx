<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true"
    CodeBehind="Hotel-Category.aspx.cs" Inherits="SES.VTTEN.WEB.Hotel_Category" Title="Untitled Page" %>

<%@ Register TagPrefix="cp" Namespace="SiteUtils" Assembly="CollectionPager" %>
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
                    Hotels In
                    <asp:Label runat="server" ID="lblCatName" Text=""></asp:Label>
                </h1>
                <div class="thinline7">
                </div>
                <asp:Repeater ID="rptHotelCat" runat="server">
                    <ItemTemplate>
                        <div class="tourcatx">
                            <div class="tourcatxy">
                                <div class="title-hotel">
                                    <div class="title-hotel-title">
                                        <h2>
                                            <a style="font-size: 15px; color: #118074" href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                                <%#Eval("Title") %></a>
                                        </h2>
                                    </div>
                                    <div class="title-hotel-star">
                                        <%#StarRate(Eval("StarRates").ToString())%>
                                    </div>
                                </div>
                            </div>
                            <div class="texttourcatx">
                                <div class="imgtourcatx">
                                    <a href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                        <img title="<%#Eval("Title") %>" src="/Media/<%#Eval("HotelImage") %>" width="180px"
                                            height="103px"></a></div>
                                <div class="contenttourcatx">
                                    <div class="contenttourcatx1">
                                        <%#WordCut(Eval("Description").ToString())%><a href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                            Read More </a>
                                    </div>
                                    <div class="contenttourcatx2">
                                        <div class="contenttourcatx3">
                                            From: US $<%#Eval("HotelStartPrice") %>
                                        </div>
                                        <div class="contenttourcatx4">
                                            <a href="/Hotel-Booking/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"
                                                style="color: #A31D1D">BOOK THIS HOTEL</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div style="width: 100%; margin-top: 10px;">
                    <div class="collection">
                        <cp:CollectionPager LabelText="" FirstText="&amp;nbsp;&amp;nbsp;<<" BackText="< &amp;nbsp;"
                            LastText=">>" NextText=">" ShowFirstLast="True" ControlCssClass="collectionpager"
                            PagingMode="PostBack" runat="server" BackNextLinkSeparator="" BackNextLocation="Split"
                            PageNumbersDisplay="Numbers" ResultsLocation="None" BackNextDisplay="HyperLinks"
                            ID="CollectionPager1" BackNextButtonStyle="" BackNextStyle="margin-left:5px;"
                            ControlStyle="" PageNumbersSeparator="&amp;nbsp;">
                        </cp:CollectionPager>
                        <div class="collectPage">
                            Page:</div>
                    </div>
                    <%-- <div style="float: left; margin-left: 0xp;">
                        <asp:ImageButton ID="cmdPrev" Visible="false" OnClick="cmdPrev_Click" runat="server"
                            ImageUrl="~/images/prevpage.png" /></div>
                    <div style="float: right; margin-right: 0px;">
                        <asp:ImageButton ID="cmdNext" Visible="false" OnClick="cmdNext_Click" runat="server"
                            ImageUrl="~/images/nextpage.png" /></div>--%>
                </div>
            </div>
        </div>
        <div class="mainR">
            <uc2:ucSearchTour ID="ucSearchTour1" runat="server" />
            <uc3:ucSendContact ID="ucSendContact1" runat="server" />
            <uc6:ucTopStarRatesHotels ID="ucTopStarRatesHotels1" runat="server" />
            <uc5:ucHotTours ID="ucHotTours1" runat="server" />
            <uc8:ucRightBanner ID="ucRightBanner2" runat="server" />
        </div>
        <!----- ### End Right Main ### ----->
    </div>
</asp:Content>
