<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHotTours.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucHotTours" %>
<div class="modul2">
    <div class="modul1in">
        <div class="titmodul1">
            Promotion Tours</div>
    </div>
    <div class="modul1list">
        <ul>
            <asp:Repeater runat="server" ID="rptHotTours">
                <ItemTemplate>
                <li>
                    <a href='/Tour/<%#Eval("TourID")%>/<%#FriendlyUrl(Eval("Alias").ToString())%>' title='<%#Eval("Title")%>'>
                        <%#Eval("Title")%>
                    </a>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</div>
