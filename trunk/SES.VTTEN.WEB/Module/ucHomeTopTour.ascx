<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHomeTopTour.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucHomeTopTour" %>
<div id="OutPromotion">
    <p style="margin">
        Out Promotions</p>
</div>
<div id="OP-Image">
    <ul id="carouselTour" class="jcarousel-skin-tango">
       <asp:Repeater ID="rptTopTour" runat="server">
       <ItemTemplate>
        <li>
            <div class="OPI-Caption">
                <a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"><%#Eval("Title") %></a></div>
            <a href="/Tour/<%#Eval("TourID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>">
                <img alt="<%#Eval("Title") %>" class="OPI-Image" src="/Media/<%#Eval("TourImage") %>"></a>
            <div class="OPI-Detail">
                <%#WordCut(Eval("MetaDes").ToString())%></div>
        </li>  
        </ItemTemplate>
        </asp:Repeater>
    </ul>
</div>
