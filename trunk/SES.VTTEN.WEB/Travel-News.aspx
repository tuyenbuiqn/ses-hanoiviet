<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true" CodeBehind="Travel-News.aspx.cs" Inherits="SES.VTTEN.WEB.Travel_News" Title="Untitled Page" %>
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
                    Travel News
                </h1>
                <div class="thinline7">
                </div>
                <asp:Repeater ID="rptReview" runat="server">
                    <ItemTemplate>
                        <div class="tourcatx">
                            <div class="tourcatxy">
                                <div class="tittourcatx">
                                    <h2>
                                        <a style="font-size: 15px; color: #118074" href="/News/<%#Eval("NewsID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                            <%#Eval("Title") %></a> 
                                </div>
                            </div>
                            <div class="texttourcatx">
                                <div class="imgtourcatx">
                                    <a href="/News/<%#Eval("NewsID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                        <img title="<%#Eval("Title") %>" src="/Media/<%#Eval("NewsImage") %>" width="180px"
                                            height="103px"></a></div>
                                <div class="contenttourcatx">
                                    <div class="contenttourcatx1">
                                        <%#WordCut(Eval("Description").ToString())%><a href="/News/<%#Eval("NewsID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"> Read More </a>
                                    </div>
                                 
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                 <div style="width: 100%; margin: 20px 0; float: right;">
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

