<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMnuHotel.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucMnuHotel" %>
<style type="text/css">
    .hotel
    {
        width: 205px;
        float: left;
    }
    .bgM .boxL .hotel li
    {
        padding: 0 !important;
        float: left !important;
        background: none !important;
        margin: 0 !important;
        position: static;
    }
    .bgM .boxL .hotel li a
    {
        font-size: 12px;
        margin: 0 2px;
        color: #14529B;
        line-height: 16px;
    }
</style>
<div class="subMenuCon" id="meganavMotoring" style="opacity: 0; width: 984px; display: none;">
    <div class="con">
        <div class="bgM">
            <div class="boxL">
                <div class="heading2">
                    <h3>
                        <asp:HyperLink ID="hplVN1" runat="server">Hotels in VietNam</asp:HyperLink>
                    </h3>
                </div>
                <p>
                    <asp:Repeater runat="server" ID="rptHotels">
                        <ItemTemplate>
                            <a href='/Hotel-Category/<%#Eval("DestinationID") %>/<%#FriendlyUrl(Eval("Title").ToString())%>'
                                title='<%#Eval("Title") %>'>
                                <%#Eval("Title") %>
                            </a><span class="divide" style="margin: 0 0.0em;">| </span>
                        </ItemTemplate>
                    </asp:Repeater>
                </p>
            </div>
            <asp:Repeater runat="server" ID="rptTopRate">
                <ItemTemplate>
                    <div class="boxNew">
                        <div class="abo1">
                            <a href='/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Title").ToString())%>'
                                title='<%#Eval("Title") %>'>
                                <%#Eval("Title") %>
                            </a>
                        </div>
                        <p style="width:100%;">
                            <%#StarRate(Eval("StarRates").ToString())%>
                        </p>
                        <p style="text-align:justify;">
                            <%#WordCut(Eval("Description").ToString()) %>
                        </p>
                        <p>
                            <a href='/Hotel/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Title").ToString())%>'
                                title='<%#Eval("Title") %>'>
                                <img class="" src='/Media/<%#Eval("HotelImage") %>' border="0" width="206" height="95"></a></p>
                        <p style="font-size: 16px; color: #900">
                            Only US$
                            <%#Eval("HotelStartPrice") %>
                            / Room</p>
                        <p style="width:207px; height:25px; background-color:#06C; color:#FFF; padding-top:10px;">
                            <span style="margin-left: 50px; font-size: 14px; font-weight: bold"><a href='/Hotel-Booking/<%#Eval("HotelID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>' style="color:#FFF !important;">BOOKING NOW</a></span>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div class="bgB">
    </div>
</div>
