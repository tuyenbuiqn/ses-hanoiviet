<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucRelatedTour.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucRelatedTour" %>
<div class="toursub2">
    <h3>
        RELATED TOUR</h3>
</div>
<div class="toursub2">
    <asp:Repeater runat="server" ID="rptRelatedTours">
        <ItemTemplate>
            <div class="toursub12">
                <div class="in1toursub10">
                    <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Title").ToString())%>' title='<%#Eval("Title")%>'>
                        <%#Eval("Title")%>
                    </a>
                </div>
                <div class="in2toursub10">
                    <%#Duration(Eval("DurationDay").ToString(), Eval("DurationNight").ToString())%></div>
                <div class="in3toursub10">
                    Price:</div>
                <div class="in4toursub10">
                    US $<%#Eval("TourPrice") %></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
