<%@ Page Language="C#" MasterPageFile="~/ListTour.Master" AutoEventWireup="true" CodeBehind="Hotel.aspx.cs" Inherits="SES.VTTEN.WEB.Hotel" Title="Untitled Page" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<link href="/css/skin.css" rel="stylesheet" type="text/css" />
<div class="divTourDetail">
    <div class="DanhSachTour-title">
        <div>
            <p>
                <a href="/Default.aspx" title="Trang chủ">Trang chủ</a>&nbsp;» &nbsp;
                <a href="/Hotel-Category/0/Default.aspx" title="Danh sách khách sạn">Danh sách khách sạn</a>&nbsp;» &nbsp;
                <asp:Label runat="server" ID="lblHotelNameTitle" Text=""></asp:Label>
            </p>
        </div>
        <img style="border: 0px;" src="/image/ImgTitleIcon.png" />
    </div>
    <div class="DanhSachTour-box">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
         </cc1:ToolkitScriptManager>
        <div class="DanhSachTour-detail">
            <p class="Title"><asp:Label runat="server" ID="lblHotelName" Text=""></asp:Label></p>
            <p class="Price">Giá Tour: <asp:Label runat="server" ID="lblHotelPrice" CssClass="Price" Text=""></asp:Label>đ</p>
            <p class="MoTaChung">Mô tả chung:</p>
            <p class="descriptions"><asp:Label runat="server" ID="lblDescription" Text=""></asp:Label></p>
        
        </div>
        <div class="DetailImgNho" style="margin-top: 3px;">
            <asp:Repeater ID="rpImage" runat="server">
                <ItemTemplate>
                    <a class="fancybox-tourimg" rel="tourimg" title="<%#Eval("Title") %>" href="/Media/<%#Eval("MediaFile") %>">
                        <img src="/Media/<%#Eval("MediaFile") %>" alt="<%#Eval("Title") %>">
                    </a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <asp:HyperLink CssClass="fancybox-tourimg DetailImgBig" ID="hplImg" runat="server">
            <asp:Image ID="ImgHotel" CssClass="ImgDetail" runat="server" />
        </asp:HyperLink>
    </div>
    <div class="DetailLichTrinh" style="float: left; width: 100%; border: 1px solid #5EB7CE; padding-left: 5px; padding-bottom: 10px;">
    <div class="contentourdt1">
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
    <div class="DetailAction" style="float: left; width: 100%; text-align: right; margin-top: 10px;">
        <div class="Action">
            <asp:HyperLink ID="hplBook" runat="server">
                <img  alt="lnkBookNow" title="BookNow" style="border: 0px;" src="/image/IconBookNow.png" />
            </asp:HyperLink>
            
        </div>
    </div>
</div>
</asp:Content>
