<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHotelList.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucHotelList" %>
<%@ Register TagPrefix="cp" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Repeater ID="rptHotelCat" runat="server">
    <ItemTemplate>
        <div class="DanhSachTour-box">
            <div class="DanhSachTour-detail">
                <a href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" title="<%#Eval("Title") %>"><p class="Title"><%#Eval("Title") %></p></a>
                <p class="Price">Giá Khách sạn: <%#Eval("HotelStartPrice", "{0:0,000}")%>đ</p>
                <p class="MoTaChung">Mô tả chung:</p>
                <p class="descriptions">
                    <%#WordCut(Eval("Description").ToString())%>
                    <a href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" title="<%#Eval("Title") %>">
                    <span style="color: #4704CE;">Read More</span>
                    </a>
                </p>
                <div class="Action">
                    <a href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                        <img  alt="lnkBookNow" title="BookNow" style="border: 0px;" src="/image/IconBookNow.png" />
                    </a>
                </div>
            </div>
            <a href="/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" class="DanhSachTourImg" >
                <img alt="<%#Eval("Title") %>" title="<%#Eval("Title") %>" src="/Media/<%#Eval("HotelImage") %>" />
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