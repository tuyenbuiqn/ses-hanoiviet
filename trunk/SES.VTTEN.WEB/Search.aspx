<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SES.VTTEN.WEB.Search" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="cp" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DanhSachTour-title">
        <div>
            <p>
                <asp:Label ID="lblTitle" runat="server" Text="Tìm Kiếm"></asp:Label></p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
    <asp:Repeater ID="rptTourCat" runat="server">
        <ItemTemplate>
            <div class="DanhSachTour-box">
                <div class="DanhSachTour-detail">
                    <a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" title="<%#Eval("Title") %>"><p class="Title"><%#Eval("Title") %> (<%#Duration(Eval("DurationDay").ToString(), Eval("DurationNight").ToString())%>)</p></a>
                    <p class="Price">Giá Tour: <%#Eval("TourPrice", "{0:0,000}")%>đ</p>
                    <p class="Time">Duration: <%#Duration(Eval("DurationDay").ToString(), Eval("DurationNight").ToString())%></p>
                    <p class="Code">Trip Code: <%#Eval("TourCode")%></p>
                    <p class="MoTaChung">Mô tả chung:</p>
                    <p class="descriptions"><%#WordCut(Eval("MetaDes").ToString())%></p>
                    <div class="Action">
                        <a href="/Tour-Booking/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                            <img  alt="lnkBookNow" title="BookNow" style="border: 0px;" src="/image/IconBookNow.png" />
                        </a>
                        <a href="/Custom-Tour/0/Customize-your-own-trips.aspx">
                            <img  alt="lnkCustomizeTour" title="CustomizeTour" style="border: 0px;" src="/image/IconCustomizeTour.png" />
                        </a>
                    </div>
                </div>
                <a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" class="DanhSachTourImg" >
                    <img alt="<%#Eval("Title") %>" title="<%#Eval("Title") %>" src="/Media/<%#Eval("TourImage") %>" />
                </a>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div style="width: 100%;float: right; text-align: right;">
        <div class="collection">
            <cp:CollectionPager LabelText="" 
                FirstText="&amp;nbsp;&amp;nbsp;<<" BackText="< &amp;nbsp;"
                LastText=">>" NextText=">" ShowFirstLast="True" ControlCssClass="collectionpager"
                PagingMode="PostBack" runat="server" BackNextLinkSeparator="" BackNextLocation="Split"
                PageNumbersDisplay="Numbers" ResultsLocation="None" BackNextDisplay="HyperLinks"
                ID="CollectionPager1" BackNextButtonStyle="" BackNextStyle="margin-left:5px;"
                ControlStyle="" PageNumbersSeparator="&amp;nbsp;" ShowLabel="True">
            </cp:CollectionPager>
            <div class="collectPage">Page: 
            </div>
        </div>
    </div>
</asp:Content>
<%--
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Panel">
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
    </div>
</asp:Content>--%>
