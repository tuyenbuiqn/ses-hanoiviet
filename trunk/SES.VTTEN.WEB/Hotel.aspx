<%@ Page Language="C#" MasterPageFile="~/HanoiViet.Master" AutoEventWireup="true" CodeBehind="Hotel.aspx.cs" Inherits="SES.VTTEN.WEB.Hotel" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="Module/ucTourCateLeftMenu.ascx" TagName="ucTourCateLeftMenu" TagPrefix="uc1" %>
<%@ Register Src="Module/ucSearchTour.ascx" TagName="ucSearchTour" TagPrefix="uc2" %>
<%@ Register Src="Module/ucSendContact.ascx" TagName="ucSendContact" TagPrefix="uc3" %>
<%@ Register Src="Module/ucRelatedTour.ascx" TagName="ucRelatedTour" TagPrefix="uc4" %>
<%@ Register Src="Module/ucHotTours.ascx" TagName="ucHotTours" TagPrefix="uc5" %>
<%@ Register Src="Module/ucTopStarRatesHotels.ascx" TagName="ucTopStarRatesHotels"
    TagPrefix="uc6" %>
    
    <%@ Register Src="Module/ucLeftBanner.ascx" TagName="ucLeftBanner"
    TagPrefix="uc7" %>
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
                    <asp:Label runat="server" ID="lblHotelName" Text=""></asp:Label>
                </h1>
                <div class="thinline7">
                </div>
                <div class="tourdt1">
                    <div class="intourdt1">
                        <asp:Label runat="server" ID="lblStarRate" Text=""></asp:Label></div>
                    <div class="intourdt2">
                        <span>Price start from</span>
                        <br />
                        <asp:Label runat="server" ID="lblHotelPrice" CssClass="Price" Text=""></asp:Label>
                    </div>
                    <div class="intourdt3">
                        <asp:HyperLink ID="hplBook" runat="server">
                            <img src="/images/booknow.png" alt="Book this Hotel" Title="Book this Hotel" /></asp:HyperLink>
                    </div>
                </div>
                <div class="thinline7">
                </div>
                <div class="contentourdt1">
                    <asp:Label runat="server" ID="lblDescription" Text=""></asp:Label>
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
                            <asp:HyperLink CssClass="fancybox-tourimg" ID="hplImg" runat="server">
                                <asp:Image ID="ImgHotel" Width="378px" Height="220px" runat="server" />
                            </asp:HyperLink>
                        </div>
                    </div>
                </div>
                <div class="tabmain2">
                    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" CssClass="ajax__tab_blueGrad-theme">
                        <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Hotel Description">
                            <ContentTemplate>
                                <asp:Label runat="server" ID="lblFullDescription" Text=""></asp:Label>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Hotel Information">
                            <ContentTemplate>
                                <asp:Label runat="server" ID="lblHotelInformation"></asp:Label>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Recommended">
                            <ContentTemplate>
                                <asp:Label runat="server" ID="lblRecommended" Text=""></asp:Label>
                            </ContentTemplate>
                        </cc1:TabPanel>
                    </cc1:TabContainer>
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
           
            <uc5:ucHotTours ID="ucHotTours1" runat="server" />
            <uc8:ucRightBanner ID="ucRightBanner1" runat="server" />
        </div>
        <!----- ### End Right Main ### ----->
    </div>
</asp:Content>
