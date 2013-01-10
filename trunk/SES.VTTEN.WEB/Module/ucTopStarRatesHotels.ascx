<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTopStarRatesHotels.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucTopStarRatesHotels" %>
<div class="modul1">
    <div class="modul1in">
        <div class="titmodul1">
            Top Hotels in Month</div>
    </div>
    <div class="modul1list">
        <ul>
        <asp:Repeater runat="server" ID="rptTopRateHotel">
            <ItemTemplate>
                <li>
                    <a href='/Hotel/<%#Eval("HotelID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' title='<%#Eval("Title")%>' >
                    <%#Eval("Title")%>
                    </a>
                </li>
            </ItemTemplate>
        </asp:Repeater>
        </ul>
    </div>
</div>

