<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTourDetail.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucTourDetail" %>
<div class="DanhSachTour-box">
    <div class="DanhSachTour-detail">
        <p class="Title"><asp:Label runat="server" ID="lblTourName" Text=""></asp:Label></p>
        <p class="Price">Giá Tour: <asp:Label runat="server" ID="lblPrice" CssClass="Price" Text=""></asp:Label>đ</p>
        
        <p class="Time">Duration: <asp:Label runat="server" ID="lblDurationDay" Text=""></asp:Label></p>
        <p class="Code">Trip Code: <asp:Label runat="server" ID="lblTourCode" Text=""></asp:Label></p>
        <p class="MoTaChung">Mô tả chung:</p>
        <p class="descriptions"><asp:Label runat="server" ID="lblDescription" Text=""></asp:Label></p>
        
    </div>
    <div class="DetailImgNho" style="margin-top: 3px;">
        <asp:Repeater ID="rpImage" runat="server">
            <ItemTemplate>
                <a class="fancybox-tourimg" rel="group1" title="<%#Eval("Title") %>" href="/Media/<%#Eval("MediaFile") %>">
                    <img src="/Media/<%#Eval("MediaFile") %>" alt="<%#Eval("Title") %>">
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <div class="DetailImgBig" style="margin-top: 3px;">
        <asp:Image ID="ImgDetail" CssClass="ImgDetail" runat="server" />
    </div>
</div>
<div class="DetailLichTrinh" style="float: left; width: 100%; border: 1px solid #5EB7CE; padding-left: 5px; padding-bottom: 10px;">
    <p style="float: left; width: 100%; color: #12487f; font-size: 14px; font-weight: bold; text-transform: uppercase; margin: 10px 0px 10px 0px;">
        Lịch trình tour
    </p>
    <asp:Label runat="server" ID="lblTourItinerary" Text=""></asp:Label>
</div>
<div class="DetailAction" style="float: left; width: 100%; text-align: right; margin-top: 10px;">
    <div class="Action">
        <asp:HyperLink ID="hplBooking" runat="server">
            <img  alt="lnkBookNow" title="BookNow" style="border: 0px;" src="/image/IconBookNow.png" />
            </asp:HyperLink>
        <a href="/Custom-Tour/0/Customize-your-own-trips.aspx">
            <img  alt="lnkCustomizeTour" title="CustomizeTour" style="border: 0px;" src="/image/IconCustomizeTour.png" />
        </a>
    </div>
</div>