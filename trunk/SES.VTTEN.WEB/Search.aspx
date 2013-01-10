﻿<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SES.VTTEN.WEB.Search" Title="Untitled Page" %>
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
                    SEARCH RESULT
                </h1>
                <div class="thinline7">
                </div>
                <asp:Repeater ID="rptTourCat" runat="server">
                    <ItemTemplate>
                        <div class="tourcatx">
                            <div class="tourcatxy">
                                <div class="tittourcatx">
                                    <h2>
                                        <a style="font-size: 15px; color: #118074" href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                            <%#Eval("Title") %></a> <span style="color: #5E5E5E; font-weight: normal;">(<%#Duration(Eval("DurationDay").ToString(), Eval("DurationNight").ToString())%>)</span></h2>
                                </div>
                            </div>
                            <div class="texttourcatx">
                                <div class="imgtourcatx">
                                    <a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                                        <img title="<%#Eval("Title") %>" src="/Media/<%#Eval("TourImage") %>" width="180px"
                                            height="103px"></a></div>
                                <div class="contenttourcatx">
                                    <div class="contenttourcatx1">
                                        <%#WordCut(Eval("MetaDes").ToString())%><a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"> Read More </a>
                                    </div>
                                    <div class="contenttourcatx2">
                                        <div class="contenttourcatx3">
                                            From: US $<%#Eval("TourPrice") %> / Pax
                                        </div>
                                        <div class="contenttourcatx4">
                                            <a style="color: #A31D1D" href="/Tour-Booking/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">BOOK THIS TOUR</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <div style="width: 100%; float: left; margin-top: 10px;">
                    <div style="float: left; margin-left: 0xp;">
                        <asp:ImageButton ID="cmdPrev" Visible="false" OnClick="cmdPrev_Click" runat="server"
                            ImageUrl="~/images/prevpage.png" /></div>
                    <div style="float: right; margin-right: 0px;">
                        <asp:ImageButton ID="cmdNext" Visible="false" OnClick="cmdNext_Click" runat="server"
                            ImageUrl="~/images/nextpage.png" /></div>
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
