<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true"
    CodeBehind="Tour.aspx.cs" Inherits="SES.VTTEN.WEB.Tour" Title="Untitled Page" %>
<%@ Register src="Module/ucTourDetail.ascx" tagname="ucTourDetail" tagprefix="uc1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divTourDetail">
        <uc1:ucTourDetail ID="ucTourDetail1" runat="server" />
   </div>
    <%--<div id="Panel">
        <div class="menuleftmain1">
            <uc1:ucTourCateLeftMenu ID="ucTourCateLeftMenu1" runat="server" />
            <uc7:ucLeftBanner ID="ucLeftBanner1" runat="server" />
        </div>
        <div class="left-content">
            <div class="content">
                <h1>
                    <asp:Label runat="server" ID="lblTourName" Text=""></asp:Label>
                </h1>
                <div class="thinline7">
                </div>
                <div class="tourdt1">
                    <div class="intourdt1">
                        Tour code:<asp:Label runat="server" ID="lblTourCode" Text=""></asp:Label></div>
                    <div class="intourdt2">
                        <span>Price start from</span>
                        <br />
                        <asp:Label runat="server" ID="lblPrice" CssClass="Price" Text=""></asp:Label>
                    </div>
                    <div class="intourdt3">
                        <asp:HyperLink ID="hplBooking" runat="server">
                            <img src="/images/booknow.png" alt="Book this tour" />
                            </asp:HyperLink>
                            <a href="/Custom-Tour/0/Customize-your-own-trips.aspx">
                            <img src="/images/bookcus.png" alt="Customize this tour" />
                            </a>
                            
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
                                <asp:Image ID="ImgTour" Width="378px" Height="220px" runat="server" />
                            </asp:HyperLink>
                        </div>
                    </div>
                </div>
                <div class="tabmain2">
                    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" CssClass="ajax__tab_blueGrad-theme">
                        <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Tour itinerary">
                            <ContentTemplate>
                                <asp:Label runat="server" ID="lblTourItinerary" Text=""></asp:Label>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Tour note">
                            <ContentTemplate>
                                <asp:Label runat="server" ID="lblTourNote"></asp:Label>
                            </ContentTemplate>
                        </cc1:TabPanel>
                        <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Tour Prices">
                            <ContentTemplate>
                                <asp:Label runat="server" ID="lblTourAllPrice" Text=""></asp:Label>
                            </ContentTemplate>
                        </cc1:TabPanel>
                    </cc1:TabContainer>
                </div>
                <uc4:ucRelatedTour ID="ucRelatedTour1" runat="server" />
            </div>
        </div>
        <div class="mainR">
            <uc2:ucSearchTour ID="ucSearchTour1" runat="server" />
            <uc3:ucSendContact ID="ucSendContact1" runat="server" />--%>
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
            <%--<uc6:ucTopStarRatesHotels ID="ucTopStarRatesHotels1" runat="server" />
            <uc5:ucHotTours ID="ucHotTours1" runat="server" />
            <uc8:ucRightBanner ID="ucRightBanner1" runat="server" />
        </div>
        <!----- ### End Right Main ### ----->
    </div>--%>
    
</asp:Content>
