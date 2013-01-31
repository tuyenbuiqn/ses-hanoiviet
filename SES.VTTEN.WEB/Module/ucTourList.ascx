<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTourList.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucTourList" %>
<%@ Register TagPrefix="cp" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Repeater ID="rptTourCat" runat="server">
    <ItemTemplate>
        <div class="DanhSachTour-box">
            <div class="DanhSachTour-detail">
                <a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>" title="<%#Eval("Title") %>"><p class="Title"><%#Eval("Title") %> (<%#Duration(Eval("DurationDay").ToString(), Eval("DurationNight").ToString())%>)</p></a>
                <p class="Price">Giá Tour: <%#Eval("TourPrice", "{0:0,000}")%>đ</p>
                <p class="Time">Thời gian: <%#Duration(Eval("DurationDay").ToString(), Eval("DurationNight").ToString())%></p>
                <p class="Code">Mã Tour: <%#Eval("TourCode")%></p>
                <p class="MoTaChung">Mô tả chung:</p>
                <p class="descriptions"><%#WordCut(Eval("MetaDes").ToString())%></p>
                <div class="Action">
                    <a href="/Tour-Booking/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                        <img  alt="lnkBookNow" title="BookNow" style="border: 0px;" src="/image/IconBookNow.png" />
                    </a>
                    <a href="/Custom-Tour/0/Customize-your-own-trips.aspx">
                        <img style="display:none;"  alt="lnkCustomizeTour" title="CustomizeTour" style="border: 0px;" src="/image/IconCustomizeTour.png" />
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
        <div class="collectPage">Trang: 
        </div>
    </div>
</div>