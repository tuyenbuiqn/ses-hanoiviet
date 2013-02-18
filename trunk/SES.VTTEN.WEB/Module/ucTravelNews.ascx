<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTravelNews.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucTravelNews" %>
<%@ Register TagPrefix="cp" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Repeater ID="rptHotelCat" runat="server" 
    onitemdatabound="rptHotelCat_ItemDataBound">
    <ItemTemplate>
        <div class="DanhSachTour-box">
            <div class="DanhSachTour-detail">
                <a href="/News/<%#Eval("NewsID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" title="<%#Eval("Title") %>"><p class="Title"><%#Eval("Title") %></p></a>
                <p class="MoTaChung">Mô tả chung:</p>
                <p class="descriptions">
                    <%#WordCut(Eval("Description").ToString())%>
                    <a href="/News/<%#Eval("NewsID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" title="<%#Eval("Title") %>">
                    <span style="color: #4704CE;">Xem tiếp</span>
                    </a>
                </p>
                <asp:Panel ID="pnlAction" runat="server">
                    <div class="Action">
                        <a href="/Services-Booking/0/Dat-dich-vu.aspx">
                            <img  alt="lnkBookNow" title="BookNow" style="border: 0px;" src="/image/IconBookServices.png" />
                        </a>
                    </div>
                </asp:Panel>
                
            </div>
            <a href="/News/<%#Eval("NewsID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" class="DanhSachTourImg" >
                <img alt="<%#Eval("Title") %>" title="<%#Eval("Title") %>" src="/Media/<%#Eval("NewsImage") %>" />
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
        <div class="collectPage">Trang: 
        </div>
    </div>
</div>