<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucTravelNewsHome.ascx.cs" Inherits="SES.VTTEN.WEB.Module.ucTravelNewsHome" %>
<div id="RightBox2">
    <div class="Captionbox">
        <p>
            TRAVEL NEWS</p>
    </div>
    <ul class="RightBoxmenu">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <li><a href="/News/<%#Eval("NewsID") %>/<%#FriendlyUrl(Eval("Alias").ToString())%>"><%#Eval("Title") %></a></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <a id="viewmore" href="/Travel-News/0/Default.aspx">View more...</a>
</div>