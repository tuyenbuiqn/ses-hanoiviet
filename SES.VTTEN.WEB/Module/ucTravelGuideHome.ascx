<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTravelGuideHome.ascx.cs"
    Inherits="SES.VTTEN.WEB.Module.ucTravelGuideHome" %>
<div id="RightBox2">
    <div class="Captionbox">
        <p>
            TRAVEL GUIDES</p>
    </div>
    <ul class="RightBoxmenu">
        <asp:Repeater ID="rptGuide" runat="server">
            <ItemTemplate>
                <li><a href="/Travel-Guide/<%#Eval("ContentID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"><%#Eval("Title") %></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <a id="viewmore" href="/Travel-Guide/0/Default.aspx">View more...</a>
</div>
